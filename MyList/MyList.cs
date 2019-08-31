using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList
    {
        private static int _index;
        private object[] _arr;
        private int _capacity = 4;
        public int Count
        {
            get
            {
                return _index;
            }
        }

        public MyList(int capacity)
        {

            _capacity = capacity;
            _arr = new object[capacity];
        }
        public MyList()
        {
            InitArray();
        }
        private void InitArray()
        {
            object[] tmpArr = _arr;
            _arr = new object[_capacity];
            if (_arr != null)
            {
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    _arr[i] = tmpArr[i];
                }
            }
        }

        public void Add(object value)
        {

            if (_index == _capacity)
            {
                _capacity *= 2;
                InitArray();
            }
            _arr[_index] = value;
            _index++;

        }
        public object this[int key]
        {
            get
            {
                return _arr[key];
            }
        }

        public void Insert(object value)
        {
            if (_index == _capacity)
            {
                _arr[++_index] = value;
               
            }
        }
        public void RemoveAt()
        {

        }
    }
}
