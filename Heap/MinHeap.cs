using System;

namespace InterviewPractice.Heap
{
    // This is an implementation of Heap
    public class MinHeap
    {
        private List<int> heap;
        public int size;

        public MinHeap()
        {
            heap = new List<int>();
            size = 0;   // Size doesn't take '0' into consideration
            heap.Add(0);    // So that we have 1-based indexing
        }

        private bool IsValidIndex(int index)
        {
            if(index > 0 && index <= size)
            {
                return true;
            }

            return false;
        }

        private int GetLeftChildIndex(int index)
        {
            return 2*index;
        }

        private int GetRightChildIndex(int index)
        {
            return 2*index + 1;
        }

        private int GetParentIndex(int index) {
            return index/2;
        }

        public int GetMin()
        {
            return size >= 1 ? heap[1] : -1;    // Or throw an error. Here assuming heap of postive numbers only.
        }

        public void Insert(int value)
        {
            heap.Add(value);
            size = heap.Count - 1;
            int index = size;
            int parentIndex = GetParentIndex(index);

            while(IsValidIndex(parentIndex) && heap[parentIndex] > value)   // Min Heap
            {
                Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = GetParentIndex(index);
            }
        }

        public int DeleteMin()
        {
            if(size <= 0)
            {
                return -1;
            }

            int min = heap[1];
            heap[1] = heap[size];
            heap.RemoveAt(size);
            size = heap.Count - 1;
            int index = 1;

            while((IsValidIndex(GetLeftChildIndex(index)) && heap[GetLeftChildIndex(index)] < heap[index]) ||
                  (IsValidIndex(GetRightChildIndex(index)) && heap[GetRightChildIndex(index)] < heap[index]))
            {
                int nextIndex = index;
                if(IsValidIndex(GetRightChildIndex(index)) && heap[GetRightChildIndex(index)] < heap[GetLeftChildIndex(index)] )
                {
                    nextIndex = GetRightChildIndex(index);
                }
                else
                {
                    nextIndex = GetLeftChildIndex(index);
                }

                Swap(index, nextIndex);
                index = nextIndex;
            }

            return min;
        }

        private void Swap(int firstIndex, int otherIndex)
        {
            int temp = heap[firstIndex];
            heap[firstIndex] = heap[otherIndex];
            heap[otherIndex] = temp;
        }
    }
}