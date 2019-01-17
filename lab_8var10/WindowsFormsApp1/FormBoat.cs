using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsCars;

namespace WindowsFormHarbour {


    public partial class FormHarbour : Form
    {

        MultiLevelHarbour harbour;

        FormBoatConfig form;

        private const int countLevel = 5;

        private Logger logger;




        public FormHarbour()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();

            harbour = new MultiLevelHarbour(countLevel, pictureBoxHarbour.Width, pictureBoxHarbour.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень" + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
      
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHarbour.Width, pictureBoxHarbour.Height);
                Graphics g = Graphics.FromImage(bmp);
                harbour[listBoxLevels.SelectedIndex].Draw(g);
                pictureBoxHarbour.Image = bmp;
            }
        }


        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            form = new FormBoatConfig();
            form.AddEvent(AddBoat);
            form.Show();
        }

        private void AddBoat(ITransport boat)
        {
            if (boat != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = harbour[listBoxLevels.SelectedIndex] + boat;

                    logger.Info(" Добавлен атомобиль " + boat.ToString() + " на место " + place);

                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonTake_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                    try
                    {
                        var boat = harbour[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxPrev.Width, pictureBoxPrev.Height);
                        Graphics g = Graphics.FromImage(bmp);
                        boat.setPosition(15, 5, pictureBoxPrev.Width, pictureBoxHarbour.Height);
                        boat.DrawBoat(g);
                        pictureBoxPrev.Image = bmp;

                        logger.Info("Изъят катер" + boat.ToString() + "c места" + maskedTextBox.Text);

                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxPrev.Width,
                       pictureBoxPrev.Height);
                        pictureBoxPrev.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    harbour.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info(" Сохранение в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сохранить не удалось :( ", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    harbour.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info(" Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
 MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

            private void Sort_Click(object sender, EventArgs e)
            {
                harbour.Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }

    


