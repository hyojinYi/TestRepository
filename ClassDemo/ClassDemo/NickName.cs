using System.Collections;

namespace NickNameDemo
{
    public class NickName
    {
        private Hashtable _names = new Hashtable();

        public string this[string key]
        {
            get { return _names[key].ToString(); }
            set { _names[key] = value; }
        }
    }
}
