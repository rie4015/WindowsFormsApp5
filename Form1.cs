using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        private int[] array = { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };
        private int[] array1 = { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };
        private int[] array2 = { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };
        private Semaphore semaphore1 = new Semaphore(0, 1); // Семафор для запуска второго потока
        private Semaphore semaphore2 = new Semaphore(0, 1); // Семафор для завершения обоих потоков
        private bool useCriticalSections; // Флаг для использования критических секций
        private object lockObject = new object(); // Объект блокировки


        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerateArray_Click_1(object sender, EventArgs e)
        {

            array = new int[] { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };
            array1 = new int[] { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };
            array2 = new int[] { 8, 3, 2, 1, 4, 5, 6, 7, 0, 9 };

            txtGeneratedArray.Text = string.Join(", ", array);
        }


        private void btnSortArray_Click(object sender, EventArgs e)
        {

            useCriticalSections = chkUseCriticalSections.Checked;


            Thread bubbleSortThread = new Thread(BubbleSort);
            Thread selectionSortThread = new Thread(SelectionSort);

            txtSortedArray.Clear();


            bubbleSortThread.Start();
            if (useCriticalSections) semaphore1.WaitOne();
            selectionSortThread.Start();

        }


        //Метод сортировки пузырьком

        private void BubbleSort()
        {
            if (useCriticalSections) Monitor.Enter(lockObject);

            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;


                    }
                    Thread.Sleep(100);
                }
            }

            if (useCriticalSections) semaphore1.Release();
            if (!useCriticalSections)
            {
                Invoke(new Action(() => txtSortedArray.Text += "Сортировка пузырьком (массив в потоке) : " + string.Join(", ", array1) + Environment.NewLine));
            }
            Invoke(new Action(() => txtSortedArray.Text += "Сортировка пузырьком (оригинальный массив): " + string.Join(", ", array) + Environment.NewLine));

            if (useCriticalSections) Monitor.Exit(lockObject);
        }

        // Метод сортировки выбором иаксимума
        private void SelectionSort()
        {
            if (useCriticalSections) Monitor.Enter(lockObject); // Вход в критическую секцию

            for (int i = 0; i < 10; i++)
            {
                int maxIdx = i;
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[j] > array[maxIdx])
                    {
                        maxIdx = j;

                    }
                    Thread.Sleep(100);
                }
                int temp = array[maxIdx];
                array[maxIdx] = array[i];
                array[i] = temp;
                array2[maxIdx] = array2[i];
                array2[i] = temp;
            }

            if (useCriticalSections) semaphore2.Release(); // Разрешение для завершения работы
            if (!useCriticalSections)
            {
                Invoke(new Action(() => txtSortedArray.Text += "Сортировка методом выбора максимума (массив в потоке) : " + string.Join(", ", array2) + Environment.NewLine));
            }
            Invoke(new Action(() => txtSortedArray.Text += "Сортировка методом выбора максимума (оригинальный массив): " + string.Join(", ", array) + Environment.NewLine));

            if (useCriticalSections) Monitor.Exit(lockObject); // Выход из критической секции
        }

    }

}
