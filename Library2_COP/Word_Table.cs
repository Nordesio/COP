using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

using System.Runtime.InteropServices;
using System.Reflection;
using Library2_COP.Classes_for_word;
using System.Windows.Forms;

namespace Library2_COP
{
    public partial class Word_Table : Component
    {
        public Word_Table()
        {
            InitializeComponent();
        }

        public Word_Table(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void CreateTable<T>(string filename, string title, int rowsHeight, List<T> elements, List<string> colTitles, List<string> colFields
            , List<Tuple<int, int>> mergeCells, List<string> mergeTitles)
        {
            Word.Application application = null;
            if (elements.Count == 0)
            {
                throw new Exception("Список пуст");
            }
            for(int i = 0; i < mergeCells.Count - 1; i++)
            {
                if(mergeCells[i].Item2 >= mergeCells[i + 1].Item1)
                {
                    throw new Exception("ячейки налазят на друг друга");
                }
            }
            if(colTitles.Count != colFields.Count)
            {
                throw new Exception("Ячейки шапок не равны кол-ву ячеек в списке");
            }
            try
            {
                application = new Word.Application();
                var document = application.Documents.Add();
                var paragraph = document.Paragraphs.Add();
                paragraph.Range.Text = title;


                application.ActiveDocument.SaveAs(filename);


                Word.Table tbl = application.ActiveDocument.Tables.Add(document.Range(), colFields.Count, elements.Count + 2);
                tbl.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                tbl.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int i = 0; i < colTitles.Count; i++)
                {
                    tbl.Rows[i+1].Cells[1].Range.Text = colTitles[i];
                }
                for (int i = 0; i < colFields.Count; i++)
                {
                    tbl.Rows[i + 1].Cells[1].Merge(tbl.Rows[i + 1].Cells[2]);
                }

                for (int i = 0; i < elements.Count; i++)
                {
                    var fields = elements[0].GetType().GetProperties();
                    foreach(var field in fields)
                    {
                        string value = field.GetValue(elements[i]).ToString();
                        int colIndex = 0;
                        foreach(var colField in colFields)
                        {
                            if(colField == field.Name)
                            {
                                colIndex = colFields.IndexOf(colField) + 1;
                                break;
                            }
                        }
                        if(colIndex != 0)
                        {
                            tbl.Rows[colIndex].Cells[i + 2].Range.Text = value;
                        }
                        else
                        {
                            throw new Exception("aboba");
                        }

                    }
                }

                int num = 0;
                for (int i = mergeCells.Count -1; i >=0; i--)
                {
                    Tuple<int, int> xTup = mergeCells[i];
                    for (int y = xTup.Item1; y <= xTup.Item2; y++) {
                        
                        tbl.Cell(y, 1).Split(1, 2);
                        tbl.Cell(y, 2).Range.Text = colTitles[y - 1];   
                        tbl.Cell(y, 1).Range.Text = "";
                    }

                    tbl.Cell(xTup.Item1, 1).Range.Text = mergeTitles[num];
                    tbl.Cell(xTup.Item1, 1).Merge(tbl.Cell(xTup.Item2, 1));
                   
                    num++;
                   
                }

                document.Close();

            }
            finally
            {
                if (application != null)
                {
                    application.Quit();
                    Marshal.FinalReleaseComObject(application);
                }
            }
            
        }
    }
}
