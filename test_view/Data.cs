using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library2_COP.Classes_for_word;
namespace test_view
{
    public class Data
    {
        public List<Test> test = new List<Test>();

        public Data()
        {
            test.Add(new Test { status = "no", name = "vlad", family = "gusev", year = 20 });
            test.Add(new Test { status = "yes", name = "kirill", family = "dolgov", year = 20 });
            test.Add(new Test { status = "no", name = "alex", family = "senkin", year = 20 });
            test.Add(new Test { status = "yes", name = "123", family = "321", year = 1000 });
            test.Add(new Test { status = "no", name = "321", family = "123", year = 201 });

        }

    }
}
