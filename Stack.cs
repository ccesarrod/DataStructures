namespace datastructres
{
    // Represents a simple last-in-first-out (LIFO) non-generic collection of objects.
    public class  StackList<T>
    {
        private int _count;
       private  const int MAX = 1000;
        int top=0;
        T[] stack = new T[MAX];

        public int Count => _count;
        public void Push(T new_data)
        {
            stack[++top] = new_data;
            _count++;
        }

        public T Pop()
        {
            if (top < 0)
            {

                return default(T);
            }
            else
            {
                var  value = stack[top--];
                _count--;
                return value;
            }
        }
    }
}
