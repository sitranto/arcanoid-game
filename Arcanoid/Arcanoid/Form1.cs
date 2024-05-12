using Arcanoid.arcanoidFigures;
using System;

namespace Arcanoid
{
    public partial class arcanoidForm : Form
    {
        private int amountRows = 5;
        private int amountColumns = 10;
        private Block[,] blocks;
        private (double blockHeight, double blockWidth) blockSize;

        public arcanoidForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            blocks = new Block[amountRows, amountColumns];
            for (var row = 0; row < amountRows; row++)
            {
                for (var col = 0; col < amountColumns; col++)
                {
                    blocks[row, col] = new Block(0, 0, 0, 0) { blockColor = Brushes.White };
                }
            }
        }


    }
}
