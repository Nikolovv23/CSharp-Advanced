using System.Collections;
using System.Runtime.CompilerServices;

namespace IteratorsAndComparatorsExercise
{
    public class Lake : IEnumerable<int>
    {
        private readonly List<int> list;

        public Lake(List<int> list)
        {
            this.list = list;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++) 
            {
                if (i % 2 == 0)
                {
                    yield return this.list[i];
                }
            }
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.list[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
