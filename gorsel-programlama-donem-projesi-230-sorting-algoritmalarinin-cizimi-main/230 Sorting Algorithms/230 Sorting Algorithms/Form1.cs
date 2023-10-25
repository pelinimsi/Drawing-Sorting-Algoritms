using Microsoft.VisualBasic.Devices;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace _230_Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        int[] array = new int[50];
        Graphics g = null;
        Pen pen = null;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            array_start();
            panel1.Refresh();
        }
        public void delay()
        {
            for (int i = 0; i < 50000/speed_bar.Value; i++)
                for (int j = 0; j < 4000; j++)
                    continue;

        }
        public void draw_array()
        {
            g.Clear(color:Color.SlateGray);
            Pen p = new Pen(color: Color.Black, 5);
            for (int i = 0; i < 50; i++)
            {
                g.DrawEllipse(p, i * 10+35, 500 - 10 * array[i]+35, 10, 10);
                g.DrawEllipse(pen, i * 10 + 38, 503 - 10 * array[i]+35, 4, 4);
            }
            delay();

        }
        public void array_start()
        {
            for (int i = 0; i < 50; i++)
            {
                array[i] = i + 1;
            }
        }
        public void random_array()
        {
            array_start();
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    int temp_random = rnd.Next(1, 50);
                    int temp = array[temp_random];
                    array[temp_random] = array[j];
                    array[j] = temp;
                }
            }
        }
       
        
        public void bubbleSort()
        {

            for (int step = 0; step < 50 - 1; ++step)
            {

                for (int i = 0; i < 50 - step - 1; ++i)
                {

                    if (array[i] > array[i + 1])
                    {

                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                draw_array();

            }
        }
        void selectionSort()
        {
            int size = 50;
            for (int step = 0; step < size; step++)
            {
                int min_idx = step;
                for (int i = step + 1; i < size; i++)
                {

                    // To sort in descending order, change > to < in this line.
                    // Select the minimum element in each loop.
                    if (array[i] < array[min_idx])
                        min_idx = i;

                }
                draw_array();
                // put min at the correct position
                int temp;
                temp = array[min_idx];
                array[min_idx] = array[step];
                array[step] = temp;
            }
        }
        void InsertionSort()
        {
            int size = 50;
            for (int step = 1; step < size; step++)
            {
                int key = array[step];
                int j = step - 1;

                // Compare key with each element on the left of it until an element smaller than
                // it is found.
                // For descending order, change key<array[j] to key>array[j].
                while (key < array[j] && j > 0)
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = key;
                draw_array();
            }
            array_start();
            draw_array();
        }


        public void countSort()
        {
            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
            }
            for (int i = array.Length-1; i>=0; i--)
            {
                array[i] = output[i];
                draw_array();
            }
        }

        public int[] RadixSort()
        {
            int max = 50;
            

            for (int digit = 1; max / digit/50 > 0; digit *= 50)
            {
                int[] buckets = new int[50];

                for (int i = 0; i < array.Length; i++)
                {
                    int bucketIndex = array[i] / digit % 50;
                    buckets[bucketIndex]++;
                }

                int index = 0;
                for (int bucket = 0; bucket < buckets.Length ; bucket++)
                {
                    for (int i = 0; i < buckets[bucket]; i++)
                    {
                        array[index++] = bucket * digit;
                        draw_array();
                    }
                }
            }
                      return array;
        }


        public void BucketSort()
        {
            int minValue = array[0];
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
                if (array[i] < minValue)
                    minValue = array[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] - minValue].Add(array[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[k] = bucket[i][j];
                        k++;
                        draw_array();
                    }
                }
            }
        }

        public void QuickSortIterative()
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            int top = -1;
            int[] stack = new int[array.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(startIndex, endIndex);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex+1)
                {
                    stack[++top] = p + 1;
                    stack[++top] = endIndex;
                }
            }
            array_start();
            draw_array();
        }

        private int Partition(int left, int right)
        {
            int x = array[right];
            int i = (left - 1);

            for (int j = left; j <= right - 1; ++j)
            {
                if (array[j] <= x)
                {
                    ++i;
                    Swap(ref array[i], ref array[j]);
                    draw_array();
                }
            }
            
            Swap(ref array[i + 1], ref array[right]);

            draw_array();
            return (i + 1);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int shellsort()
        {
            int n = array.Length;

            // Start with a big gap,
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    int temp = array[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];

                    // put temp (the original a[i])
                    // in its correct location
                    array[j] = temp;
                    draw_array();
                }
            }
            return 0;
        }

        void heapify(int sizeHeap, int parentIndex)
        {
            // Establishing a relationship between indices of a node and indices of 
            // its left and right children 
            int larger = parentIndex;
            int leftChildIndex = 2 * parentIndex + 1;
            int rightChildIndex = 2 * parentIndex + 2;

            // Making sure the parent is greater than or equal to its left and right 
            // children
            if (leftChildIndex < sizeHeap && array[leftChildIndex] > array[larger])
                larger = leftChildIndex;

            if (rightChildIndex < sizeHeap && array[rightChildIndex] > array[larger])
                larger = rightChildIndex;

            // Swap and heapify if parent/root is not the largest
            if (larger != parentIndex)
            {
                int temp = array[parentIndex];
                array[parentIndex] = array[larger];
                array[larger] = temp;
                heapify(sizeHeap, larger);
                draw_array();
            }
        }


        void heapSort()
        {
            int sizeArray = 50;
            // Creating max  heap, iterating for all  non=leaf indices, since leaf 
            // indices don't have children to check for

            for (int nonleafNodeIndex = sizeArray / 2 - 1; nonleafNodeIndex >= 0; nonleafNodeIndex--)
                heapify(sizeArray, nonleafNodeIndex);

            // Swap the root element of the heap with the last heap index, the 
            // Reduce heap size till it becomes 2 (last heap index 
            // is 1)

            for (int lastHeapIndex = sizeArray - 1; lastHeapIndex >= 1; lastHeapIndex--)
            {
                int temp = array[lastHeapIndex];
                array[lastHeapIndex] = array[0];
                array[0] = temp;
                draw_array();

                // Heapifying root element so that the highest element is again at the 
                // root
                heapify(lastHeapIndex, 0);
            }

        }






        public void shakerSort()
        {
            int t;
            int exchange;
            do
            {
                exchange = 0;
                for (int i = 50 - 1; i > 0; --i)
                {
                    if (array[i - 1] > array[i])
                    {
                        t = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = t;
                        exchange = 1;
                    }
                    if ((i % 5) == 0)
                        draw_array();
                }

                for (int i = 1; i < 50; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        t = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = t;
                        exchange = 1;
                    }
                    if ((i % 5) == 0)
                        draw_array();
                }
            } while (exchange == 1);
        }
        public void gnomeSort()
        {
            int index = 0;

            while (index < 50)
            {
                if (index == 0)
                    index++;
                if (array[index] >= array[index - 1])
                    index++;
                else
                {
                    int temp = 0;
                    temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
                if (index % 10 == 0)
                    draw_array();
            }
            return;
        }

        public void stoogesort(int l,int h)
        {
            if (l >= h)
                return;

            // If first element is smaller
            // than last, swap them
            if (array[l] > array[h])
            {
                int t = array[l];
                array[l] = array[h];
                array[h] = t;
                if (l % 3 == 0 )
                    draw_array();
            }

            // If there are more than 2
            // elements in the array
            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;

                // Recursively sort first
                // 2/3 elements
                stoogesort(l, h - t);

                // Recursively sort last
                // 2/3 elements
                stoogesort(l + t, h);

                // Recursively sort first
                // 2/3 elements again to
                // confirm
                stoogesort(l, h - t);
            }
        }

        public int getNextGap(int gap)
        {
            // Shrink gap by Shrink factor
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }

        // Function to sort arr[] using Comb Sort
        public void combsort()
        {
            int n = 50;

            // initialize gap
            int gap = n;

            // Initialize swapped as true to
            // make sure that loop runs
            bool swapped = true;

            // Keep running while gap is more than
            // 1 and last iteration caused a swap
            while (gap != 1 || swapped == true)
            {
                // Find next gap
                gap = getNextGap(gap);

                // Initialize swapped as false so that we can
                // check if swap happened or not
                swapped = false;

                // Compare all elements with current gap
                for (int i = 0; i < n - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        // Swap arr[i] and arr[i+gap]
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        draw_array();
                        // Set swapped
                        swapped = true;
                    }
                }
            }
        }


        public void cocktailSort()
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped == true)
            {

                // reset the swapped flag on entering the
                // loop, because it might be true from a
                // previous iteration.
                swapped = false;

                // loop from bottom to top same as
                // the bubble sort
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                draw_array();
                // if nothing moved, then array is sorted.
                if (swapped == false)
                    break;

                // otherwise, reset the swapped flag so that it
                // can be used in the next stage
                swapped = false;

                // move the end point back by one, because
                // item at the end is in its rightful spot
                end = end - 1;

                // from top to bottom, doing the
                // same comparison as in the previous stage
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                // increase the starting point, because
                // the last stage would have moved the next
                // smallest number to its rightful spot.
                start = start + 1;
                draw_array();
            }
        }


        public void double_bubble()
        {
            for(int i = 0; i < 50; i++){
                for(int j = 0; j < 25; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                for (int j = 49; j >= 25; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }

                draw_array();
            }
        }
        public void double_selection()
        {
            int n = 50;
            for (int i = 0, j = n - 1;
                     i < j; i++, j--)
            {
                int min = array[i], max = array[i];
                int min_i = i, max_i = i;
                for (int k = i; k <= j; k++)
                {
                    if (array[k] > max)
                    {
                        max = array[k];
                        max_i = k;
                    }

                    else if (array[k] < min)
                    {
                        min = array[k];
                        min_i = k;
                    }
                }
                int temp;
                // shifting the min.
                temp = array[i];
                array[i] = array[min_i];
                array[min_i] = temp;
                draw_array();
                // Shifting the max. The equal condition
                // happens if we shifted the max to arr[min_i]
                // in the previous swap.
                if (array[min_i] == max)
                {
                    temp = array[j];
                    array[j] = array[min_i];
                    array[min_i] = temp;
                }
                else
                {
                    temp = array[j];
                    array[j] = array[max_i];
                    array[max_i] = temp;
                }
                draw_array();
            }
        }

       
        












        int sort = -1;
      
        
        
        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gg = e.Graphics;
            Pen penn = new Pen(color: Color.Black, 5);
            g = gg;
            pen = penn;
            sort = listBox1.SelectedIndex;
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    pen.Color = Color.Red;
                    break;
                case 1:
                    pen.Color = Color.Blue;
                    break;
                case 2:
                    pen.Color = Color.Orange;
                    break;
                case 3:
                    pen.Color = Color.White;
                    break;
                case 4:
                    pen.Color = Color.Pink;
                    break;
                case 5:
                    pen.Color = Color.Purple;
                    break;
                case 6:
                    pen.Color = Color.Yellow;
                    break;
                case 7:
                    pen.Color = Color.Green;
                    break;
                case 8:
                    pen.Color = Color.Cyan;
                    break;
                case 9:
                    pen.Color = Color.Magenta;
                    break;
                case 10:
                    pen.Color = Color.Aqua;
                    break;
                case 11:
                    pen.Color = Color.Brown;
                    break;
                case 12:
                    pen.Color = Color.Chocolate;
                    break;
                case 13:
                    pen.Color = Color.DarkBlue;
                    break;
                case 14:
                    pen.Color = Color.Bisque;
                    break;
                case 15:
                    pen.Color = Color.DarkGray;
                    break;
            }
            for (int i = 0; i < 50; i++)
                if (array[i] == i + 1)
                {
                    if (i == 49)
                        random_array();
                }
                else
                    break;
            draw_array();
            switch (sort)
            {
                case -1:
                    break;
                case 0:
                    bubbleSort();
                    break;
                case 1:
                    selectionSort();
                    break;
                case 2:
                    InsertionSort();
                    break;
                case 3:
                    QuickSortIterative();
                    break;
                case 4:
                    countSort();
                    break;
                case 5:
                    RadixSort();
                    break;
                case 6:
                    BucketSort();
                    break;
                case 7:
                    heapSort();
                    break;
                case 8:
                    shellsort();
                    break;
                case 9:
                    shakerSort();
                    break;
                case 10:
                    stoogesort(0,49);
                    draw_array();
                    break;
                case 11:
                    combsort();
                    break;
                case 12:
                    gnomeSort();
                    break;
                case 13:
                    cocktailSort();
                    break;
                case 14:
                    double_bubble();
                    break;
                case 15:
                    double_selection();
                    break;
            }
            random_array();

        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            random_array();
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            panel1.Refresh();
        }

        bool tutus;
        int FareX, FareY;

        private void speed_bar_Scroll(object sender, EventArgs e)
        {
            speed_label.Text = speed_bar.Value.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {

                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;

            }
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {

                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }


    }
}