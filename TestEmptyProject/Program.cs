using System.Windows.Forms;
using System.Collections;
namespace Test
{
    class Test
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            TestObj o1 = new TestObj(1, "1"), o2 = new TestObj(2, "2");
            al.Add(o1);
            al.Add(o2);
            o1.i = 3;
            o1.s = "3";
            MessageBox.Show("i = " + (o1 as TestObj).i.ToString() + " s = " + (o1 as TestObj).s);
        }
    }
    class TestObj
    {
        public int i;
        public string s;
        public TestObj(int iv, string sv) { i = iv; s = sv; }
    }
}