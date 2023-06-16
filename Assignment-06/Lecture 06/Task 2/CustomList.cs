using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    internal class CustomList : IEnumerable<List>
    {
        private List[] _lists = new List[0];
        
            public List this[int i]
            {
                get { return _lists[i]; }
                set { _lists[i] = value; }
            }
            public IEnumerator<List> GetEnumerator()
            {
                return ((IEnumerable<List>)_lists).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return _lists.GetEnumerator();
            }

            public void AddElement(List element)
            {
                var newList = new List[Count + 1];
                for (int i = 0; i < Count; i++)
                {
                    newList[i] = this[i];
                }
                newList[Count] = element;
                _lists = newList;
            }

            public int Count
            {
                get { return this._lists.Length; }
            }

            public bool GetElement(int index, out List element)
            {
                if (index >= Count)
                {
                    element = new List();
                    return false;
                }

                element = _lists[index];

                return true;
            }

            public bool GetList(int index, int numberOfElements, out CustomList list)
            {
                list = new CustomList();

                if (index >= Count || index + numberOfElements >= Count)
                {
                    return false;
                };

                for (int i = index; i < index + numberOfElements; i++)
                {
                    list.AddElement(this[i]);
                }

                return true;
            }

            public List Find(string name)
            {
                foreach (var element in _lists)
                {
                    if (element.Name == name)
                        return element;
                }

                return new List();
            }

            public void Clear()
            {
                _lists = new List[0];
            }

            public bool InsertElement(int index, List element)
            {
                if (index > Count)
                    return false;

                var newList = new List[Count + 1];
                for (int i = 0; i < Count; i++)
                {
                    if (i < index)
                        newList[i] = this[i];
                    else
                        newList[i + 1] = this[i];
                }
                newList[index] = element;
                _lists = newList;
                return true;
            }

            public bool RemoveElement(int index)
            {
                if (index >= Count)
                    return false;

                var newList = new List[Count - 1];

                for (int i = 0; i < newList.Length; i++)
                {
                    if (i < index)
                        newList[i] = this[i];
                    else
                        newList[i] = this[i + 1];
                }

                _lists = newList;

                return true;
            }

            public bool RemoveList(int index, int numberOfElements)
            {
                if (index >= Count || index + numberOfElements >= Count)
                    return false;

                var newList = new List[Count - numberOfElements];

                for (int i = 0; i < newList.Length; i++)
                {
                    if (i < index)
                        newList[i] = this[i];
                    else
                        newList[i] = this[i + numberOfElements];
                }

                _lists = newList;

                return true;
            }

        public void AddElementList(CustomList list)
        {
            var newList = new List[Count + list.Count];
            for (int i = 0; i < Count; i++)
            {
                newList[i] = this[i];
            }
            for (int i = Count; i < Count + list.Count; i++)
            {
                newList[i] = list[i - Count];
            }
            _lists = newList;
        }

            public bool InsertList(int index, CustomList list)
            {

                if (index > Count)
                    return false;

                var newList = new List[Count + list.Count];

                for (int i = 0; i < Count; i++)
                {
                    if (i < index)
                        newList[i] = this[i];
                    else
                    {
                        newList[i + list.Count] = this[i];
                    }
                }

                for (int i = index; i < index + list.Count; i++)
                {
                    newList[i] = list[i - index];
                }
                _lists = newList;

                return true;
            }
            public void OutputElements()
            {
                 Console.WriteLine("\n-----------------------------");
                 foreach (List e in this)
                    {
                        Console.Write(e.Name + "; ");
                    }
             }
    
    }
}
