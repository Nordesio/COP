using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Library2_COP.Classes_for_word;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Library2_COP
{
    public partial class WordDiagramm : Component
    {
        /*
            Не визуальный компонент для создания документа с
            гистограммой. У компонента должен быть публичный метод,
            который должен принимать на вход имя файла (включая путь до
            файла), название документа (заголовок в документе), заголовок
            для диаграммы, указание расположения легенды для диаграммы
            (создать для этого перечисление), набор данных для диаграммы
            (название серии и данные для графика). Должна быть проверка
             на заполненность входных данных значениями.
          */
        /// <summary>
        /// Метод создания отчета
        /// </summary>
        public void ReportSaveDiagramm(string filename, string title, string nameGistogram,
            Legend legend, List<Test> list, string category, string value)
        {
            if (string.IsNullOrEmpty(filename) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(nameGistogram) || list.Count == 0)
            {
                throw new Exception("Fields is empty!");
            }
            CreateDoc(filename, title, nameGistogram, legend, list,category, value);

        }
        /// <summary>
        /// Создание документа
        /// </summary>
        private void CreateDoc(string fileName, string title, string nameDiagram,
            Legend chartLegendPosition, List<Test> list, string category, string value)
        {
            if (list == null)
            {
                throw new Exception("Пустой список значений!");
            }
            try
            {
                DocX document = DocX.Create(fileName);
                document.InsertParagraph(title);
                document.Paragraphs[0].Direction = Direction.RightToLeft;
                document.Paragraphs[0].Alignment = Alignment.center;
                document.Paragraphs[0].FontSize(20);
                document.Paragraphs[0].Bold();
                // создаём линейную диаграмму
                PieChart circleChart = new PieChart();
                // добавляем легенду 
                circleChart.AddLegend((ChartLegendPosition)chartLegendPosition, false);
                Series seriesFirst = new Series(nameDiagram);
                // заполняем данными
                seriesFirst.Bind(list, category, value);
                // создаём набор данных и добавляем на диаграмму
                circleChart.AddSeries(seriesFirst);
                document.InsertChart(circleChart);
                document.Save();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
