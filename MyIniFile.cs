using System.Collections.Generic;
using System.IO;

namespace FirebirdSQLMonitor
{
    /// <summary>
    /// Klasa obsługująca pliki INI, bez podziału na sekcje
    /// Umożliwia przechowywanie na zasadzie par klucz = wartość
    /// </summary>
    public class MyIniFile
    {
        private Dictionary<string, string> Items;
        private string FileName;

        /// <summary>
        /// Inicjuje obiekt klasy, nazwa podana w parametrze jest używana przez metody Save i Read
        /// </summary>
        /// <param name="fileName">Nazwa pliku</param>
        public MyIniFile(string fileName)
        {
            this.FileName = fileName;
            Items = new Dictionary<string, string>();
        }


        /// <summary>
        /// Dodaje lub aktualizuje wartość istniejącego klucza
        /// </summary>
        /// <param name="key">Nazwa klucza</param>
        /// <param name="value">Wartość klucza</param>
        public void Add(string key, string value)
        {
            if (Items.ContainsKey(key.ToUpper()))
            {
                this.Items[key.ToUpper()] = value;
            }
            else
            {
                this.Add(key.ToUpper(), value);
            }
        }

        /// <summary>
        /// Zwraca wartość klucza lub w przypadku jego braku wartość domyślną
        /// W przypadku braku klucza, para klucz wartość jest dopisywana.
        /// </summary>
        /// <param name="key">Nazwa klucza</param>
        /// <param name="defaultValue">Wartość domyślna, zwracana w przypadku braku klucza</param>
        /// <returns></returns>
        public string Get(string key, string defaultValue)
        {
            string result = defaultValue;

            if (Items.ContainsKey(key.ToUpper())) result = this.Items[key.ToUpper()];
            else
                Items.Add(key.ToUpper(), defaultValue); // dopisanie wartości domyślnej

            return result;
        }

        /// <summary>
        /// Dodaje komentarz.
        /// </summary>
        /// <param name="comment">Treść komentarza</param>
        public void AddComment(string comment)
        {
            Items.Add(";", comment);
        }

        /// <summary>
        /// Zapisuje wszystkie pary klucz - wartość do pliku.
        /// Nazwa pliku jest wskazana w konstruktorze
        /// </summary>
        /// <returns>Zwraca true jeśli zapis się powiedzie i false w przeciwnym razie</returns>
        public bool Save()
        {
            bool result = false;

            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (KeyValuePair<string, string> item in Items)
                {
                    string line;
                    string key = item.Key.ToUpper();
                    string value = item.Value;
                    if ((key == ";") || (key == "#"))
                    {
                        line = key + " " + value;
                    }
                    else
                    {
                        line = key + "=" + value;
                    }

                    writer.WriteLine(line);
                }
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Odczytuje i parsuje zawartość pliku tekstowego.
        /// Dopuszczalna struktura linii to:
        /// - para klucz = wartość
        /// - [;|#] treść komentarza
        /// Wszystkie linie nie pasujące do powyższych wzorców są ignorowane.
        /// </summary>
        /// <returns>Zwraca true jeśli odczyt się powiedzie i false w przeciwnym razie</returns>
        public bool Read()
        {
            bool result = false;

            Items.Clear();

            using (StreamReader reader = new StreamReader(FileName))
            {
                string line = reader.ReadLine().Trim();
                while ((line != null) && (line != ""))
                {
                    if ((line.Substring(0, 1) == "#") || (line.Substring(0, 1) == ";"))
                    {
                        string key = line.Substring(0, 1);
                        string value = line.Substring(2).Trim();
                        Items.Add(key, value);
                    }
                    else
                    {
                        int idx = line.IndexOf("=");
                        if (idx >= 0)
                        {
                            string key = line.Substring(0, idx).Trim();
                            string value = line.Substring(idx + 1).Trim();
                            Items.Add(key, value);
                        }
                    }
                    // wszystkie inne kombinacje są pomijane
                    line = reader.ReadLine();
                }
                result = true;
            }
            return result;
        }
    }
}
