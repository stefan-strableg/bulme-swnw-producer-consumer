using System.Diagnostics;

namespace bulme_swnw_producer_consumer
{
    public partial class ProducerConsumerForm : Form
    {
        RingBuffer<int> buffer = new RingBuffer<int>(25);
        bool running = true;
        public ProducerConsumerForm()
        {
            InitializeComponent();

            Thread producer, consumer;

            producer = new Thread(producerLoop);
            consumer = new Thread(consumerLoop);

            progressBar_buffer.Minimum = 0;
            progressBar_buffer.Maximum = (int)buffer.Capacity();
            progressBar_buffer.Value = 0;

            producer.Start();
            Thread.Sleep(500);
            consumer.Start();
        }

        private void producerLoop()
        {
            while (running)
            {
                lock (buffer)
                {
                    if (!buffer.isFull())
                        buffer.Put(0);
                }
                updateProgressBar();
                Thread.Sleep(1000 / (int)numericUpDown_producer.Value);
            }
        }

        private void consumerLoop()
        {
            while (running)
            {
                lock (buffer)
                {
                    if (!buffer.isEmpty())
                    {
                        buffer.Get();
                    }
                }
                updateProgressBar();
                Thread.Sleep(1000 / (int)numericUpDown_consumer.Value);
            }
        }

        private void updateProgressBar()
        {
            if (InvokeRequired)
                Invoke(new Action(updateProgressBar));
            else lock (buffer)
                {
                    progressBar_buffer.Value = (int)buffer.Length();
                    label_buffer.Text = buffer.Length() + "/" + buffer.Capacity();
                    if (buffer.isFull())
                        label_buffer.Text += " (full)";
                    else if (buffer.isEmpty())
                        label_buffer.Text += " (empty)";
                }
        }
    }
}