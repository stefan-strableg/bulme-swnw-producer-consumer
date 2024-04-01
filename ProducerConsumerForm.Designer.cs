namespace bulme_swnw_producer_consumer
{
    partial class ProducerConsumerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown_producer = new NumericUpDown();
            numericUpDown_consumer = new NumericUpDown();
            label_producer = new Label();
            label_consumer = new Label();
            progressBar_buffer = new ProgressBar();
            label_buffer = new Label();
            _label_comment = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_producer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_consumer).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_producer
            // 
            numericUpDown_producer.Location = new Point(46, 35);
            numericUpDown_producer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_producer.Name = "numericUpDown_producer";
            numericUpDown_producer.Size = new Size(240, 39);
            numericUpDown_producer.TabIndex = 0;
            numericUpDown_producer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown_consumer
            // 
            numericUpDown_consumer.Location = new Point(46, 106);
            numericUpDown_consumer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_consumer.Name = "numericUpDown_consumer";
            numericUpDown_consumer.Size = new Size(240, 39);
            numericUpDown_consumer.TabIndex = 1;
            numericUpDown_consumer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_producer
            // 
            label_producer.AutoSize = true;
            label_producer.Location = new Point(292, 37);
            label_producer.Name = "label_producer";
            label_producer.Size = new Size(324, 32);
            label_producer.TabIndex = 2;
            label_producer.Text = "objects produced per second";
            // 
            // label_consumer
            // 
            label_consumer.AutoSize = true;
            label_consumer.Location = new Point(292, 108);
            label_consumer.Name = "label_consumer";
            label_consumer.Size = new Size(333, 32);
            label_consumer.TabIndex = 3;
            label_consumer.Text = "objects consumed per second";
            // 
            // progressBar_buffer
            // 
            progressBar_buffer.Location = new Point(130, 445);
            progressBar_buffer.Name = "progressBar_buffer";
            progressBar_buffer.Size = new Size(1339, 46);
            progressBar_buffer.TabIndex = 4;
            // 
            // label_buffer
            // 
            label_buffer.AutoSize = true;
            label_buffer.Location = new Point(130, 410);
            label_buffer.Name = "label_buffer";
            label_buffer.Size = new Size(172, 32);
            label_buffer.TabIndex = 5;
            label_buffer.Text = "Buffer capacity";
            // 
            // _label_comment
            // 
            _label_comment.AutoSize = true;
            _label_comment.Location = new Point(116, 842);
            _label_comment.Name = "_label_comment";
            _label_comment.Size = new Size(1427, 32);
            _label_comment.TabIndex = 6;
            _label_comment.Text = "Note: While the label updates in real time, the progress bar updates with a delay. Production/ Consumption speeds are not null safe.\r\n";
            // 
            // ProducerConsumerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 883);
            Controls.Add(_label_comment);
            Controls.Add(label_buffer);
            Controls.Add(progressBar_buffer);
            Controls.Add(label_consumer);
            Controls.Add(label_producer);
            Controls.Add(numericUpDown_consumer);
            Controls.Add(numericUpDown_producer);
            Name = "ProducerConsumerForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_producer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_consumer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_producer;
        private NumericUpDown numericUpDown_consumer;
        private Label label_producer;
        private Label label_consumer;
        private ProgressBar progressBar_buffer;
        private Label label_buffer;
        private Label _label_comment;
    }
}