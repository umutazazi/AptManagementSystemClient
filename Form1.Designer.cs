namespace CinsApartmentManagementSystem
{
    partial class Form1
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
            this.weatherText = new System.Windows.Forms.Label();
            this.weatherİnfo = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.currencyInfo = new System.Windows.Forms.Label();
            this.cardReaderText = new System.Windows.Forms.Label();
            this.cardReaderListBox = new System.Windows.Forms.ListBox();
            this.getWeatherButton = new System.Windows.Forms.Button();
            this.getCurrencyButton = new System.Windows.Forms.Button();
            this.getCarReaderButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weatherText
            // 
            this.weatherText.AutoSize = true;
            this.weatherText.Location = new System.Drawing.Point(12, 24);
            this.weatherText.Name = "weatherText";
            this.weatherText.Size = new System.Drawing.Size(127, 20);
            this.weatherText.TabIndex = 0;
            this.weatherText.Text = "Current Weather : ";
            // 
            // weatherİnfo
            // 
            this.weatherİnfo.AutoSize = true;
            this.weatherİnfo.Location = new System.Drawing.Point(145, 24);
            this.weatherİnfo.Name = "weatherİnfo";
            this.weatherİnfo.Size = new System.Drawing.Size(33, 20);
            this.weatherİnfo.TabIndex = 1;
            this.weatherİnfo.Text = "null";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(12, 58);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(140, 20);
            this.currency.TabIndex = 2;
            this.currency.Text = "Currency Exchange: ";
            // 
            // currencyInfo
            // 
            this.currencyInfo.AutoSize = true;
            this.currencyInfo.Location = new System.Drawing.Point(158, 58);
            this.currencyInfo.Name = "currencyInfo";
            this.currencyInfo.Size = new System.Drawing.Size(33, 20);
            this.currencyInfo.TabIndex = 3;
            this.currencyInfo.Text = "null";
            // 
            // cardReaderText
            // 
            this.cardReaderText.AutoSize = true;
            this.cardReaderText.Location = new System.Drawing.Point(12, 132);
            this.cardReaderText.Name = "cardReaderText";
            this.cardReaderText.Size = new System.Drawing.Size(151, 20);
            this.cardReaderText.TabIndex = 4;
            this.cardReaderText.Text = "Card Reader Division:";
            // 
            // cardReaderListBox
            // 
            this.cardReaderListBox.FormattingEnabled = true;
            this.cardReaderListBox.ItemHeight = 20;
            this.cardReaderListBox.Location = new System.Drawing.Point(12, 165);
            this.cardReaderListBox.Name = "cardReaderListBox";
            this.cardReaderListBox.Size = new System.Drawing.Size(342, 144);
            this.cardReaderListBox.TabIndex = 5;
            // 
            // getWeatherButton
            // 
            this.getWeatherButton.Location = new System.Drawing.Point(223, 15);
            this.getWeatherButton.Name = "getWeatherButton";
            this.getWeatherButton.Size = new System.Drawing.Size(94, 29);
            this.getWeatherButton.TabIndex = 6;
            this.getWeatherButton.Text = "Get";
            this.getWeatherButton.UseVisualStyleBackColor = true;
            // 
            // getCurrencyButton
            // 
            this.getCurrencyButton.Location = new System.Drawing.Point(223, 54);
            this.getCurrencyButton.Name = "getCurrencyButton";
            this.getCurrencyButton.Size = new System.Drawing.Size(94, 29);
            this.getCurrencyButton.TabIndex = 7;
            this.getCurrencyButton.Text = "Get";
            this.getCurrencyButton.UseVisualStyleBackColor = true;
            // 
            // getCarReaderButton
            // 
            this.getCarReaderButton.Location = new System.Drawing.Point(120, 329);
            this.getCarReaderButton.Name = "getCarReaderButton";
            this.getCarReaderButton.Size = new System.Drawing.Size(119, 29);
            this.getCarReaderButton.TabIndex = 8;
            this.getCarReaderButton.Text = "Get";
            this.getCarReaderButton.UseVisualStyleBackColor = true;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(34, 397);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(52, 20);
            this.statusText.TabIndex = 9;
            this.statusText.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(92, 397);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(262, 27);
            this.statusTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.getCarReaderButton);
            this.Controls.Add(this.getCurrencyButton);
            this.Controls.Add(this.getWeatherButton);
            this.Controls.Add(this.cardReaderListBox);
            this.Controls.Add(this.cardReaderText);
            this.Controls.Add(this.currencyInfo);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.weatherİnfo);
            this.Controls.Add(this.weatherText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label weatherText;
        private Label weatherİnfo;
        private Label currency;
        private Label currencyInfo;
        private Label cardReaderText;
        private ListBox cardReaderListBox;
        private Button getWeatherButton;
        private Button getCurrencyButton;
        private Button getCarReaderButton;
        private Label statusText;
        private TextBox statusTextBox;
    }
}