using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yshot_bydjeta
{
    internal class logica
    {
        static List<type> typed = desir.MyDesirialize<List<type>>();
        static List<type> dop_type = new List<type>();
        public static void log(MainWindow window)
        {
            window.IsnPustGrit.ItemsSource = "";
            if (File.Exists(desir.desktop + "\\ychot.json"))
            {
                dop_type.Clear();
            }
            else
            {
                File.WriteAllText(desir.desktop + "\\ychot.json", "[]");
            }
            int count = 0;
            foreach (var type in typed)
            {
                if (type.date == window.PickData.Text.ToString())
                {
                    dop_type.Add(type);
                }



                count += type.money;




            }
            window.IsnPustGrit.ItemsSource = dop_type;

            window.vecbItog.Text = "Итого: " + count.ToString();

        }

        public static void add(MainWindow window)
        {
            string r = window.PodZagolovok.Text;
            int q = Convert.ToInt32(window.PickItog.Text);
            string t = window.type_cheng;
            /*type tu = new type(r, t, q, true, window.date.Text.ToString());*/
            typed.Add(new type(r, t, q, true, window.PickData.Text.ToString()));
            desir.MySerialeze(typed);
            typed = desir.MyDesirialize<List<type>>();
            log(window);
        }

        public static void remove(MainWindow window)
        {
            type select = window.IsnPustGrit.SelectedItem as type;
            try
            {
                foreach (var tye in typed)
                {
                    if (tye == select)
                    {
                        typed.Remove(tye);
                    }
                }
            }
            catch { }
            finally
            {
                desir.MySerialeze(typed);
                typed = desir.MyDesirialize<List<type>>();
                log(window);
            }
        }

        public static void edit(MainWindow window)
        {
            type select = window.IsnPustGrit.SelectedItem as type;
            try
            {
                foreach (var tye in typed)
                {
                    if (tye == select)
                    {
                        string r = window.PodZagolovok.Text;
                        int i = typed.IndexOf(tye);
                        int q = Convert.ToInt32(window.PickItog.Text);
                        string t = window.type_cheng;
                        typed[i] = new type(r, t, q, true, window.PickData.Text.ToString());
                    }
                }
            }
            catch { }
            finally
            {
                desir.MySerialeze(typed);
                typed = desir.MyDesirialize<List<type>>();
                log(window);
            }
        }
    }
}
