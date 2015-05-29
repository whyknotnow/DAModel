using mshtml;
using LiveSwitch.TextControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DAModel.Forms
{
    public partial class HtmlEditForm : Form
    {
        private string _filename = null;
        public HtmlEditForm()
        {
            InitializeComponent();
            HtmlEditorKontrol.Tick += new Editor.TickDelegate(HTMLKontrolEditor_Tick);
        }
        private void HtmlEditForm_Load(object sender, EventArgs e)
        {
            HtmlEditorKontrol.DocumentText = "<html><body></body></html>";
            IHTMLDocument2 doc = HtmlEditorKontrol.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";

            HtmlEditorKontrol.Document.ContextMenuShowing += new HtmlElementEventHandler(Document_ContextMenuShowing);
        }

        private void HTMLKontrolEditor_Tick()
        {
            geriAlToolStripMenuItem.Enabled = HtmlEditorKontrol.CanUndo();
            ileriAlToolStripMenuItem.Enabled = HtmlEditorKontrol.CanRedo();
            kesToolStripMenuItem.Enabled = HtmlEditorKontrol.CanCut();
            kopyalaToolStripMenuItem.Enabled = HtmlEditorKontrol.CanCopy();
            yapistirToolStripMenuItem.Enabled = HtmlEditorKontrol.CanPaste();
            resimToolStripMenuItem.Enabled = HtmlEditorKontrol.CanInsertLink();
        }       

        private void Document_ContextMenuShowing(object sender, HtmlElementEventArgs e)
        {
            
        }

        private void htmlGetirButton_Click(object sender, EventArgs e)
        {
            string mail = HtmlEditorKontrol.BodyHtml;

        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filename = null;
            Text = null;
            HtmlEditorKontrol.BodyHtml = string.Empty;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_filename == null)
            {
                if (!SaveFileDialog())
                    return;
            }
            SaveFile(_filename);
            MessageBox.Show("Kaydedildi.");
        }

        private bool SaveFileDialog()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.AddExtension = true;
                dlg.DefaultExt = "htm";
                dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _filename = dlg.FileName;
                    return true;
                }
                else
                    return false;
            }
        }

        private void SaveFile(string filename)
        {
            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.Write(HtmlEditorKontrol.DocumentText);
                writer.Flush();
                writer.Close();
            }
        }

        private void LoadFile(string filename)
        {
            using (StreamReader reader = File.OpenText(filename))
            {
                HtmlEditorKontrol.Html = reader.ReadToEnd();
                Text = HtmlEditorKontrol.DocumentTitle;
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _filename = dlg.FileName;
                }
                else
                    return;
            }
            LoadFile(_filename);
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog())
                SaveFile(_filename);
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SearchDialog dlg = new SearchDialog(HtmlEditorKontrol))
            {
                dlg.ShowDialog(this);
            }
        }

        private void tumunuSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.SelectAll();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Paste();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Undo();
        }

        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Redo();
        }

        private void duzMetinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, HtmlEditorKontrol.BodyText);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, HtmlEditorKontrol.BodyHtml);
        }

        private void yazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.Print();
        }

        private void paragrafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.InsertParagraph();
        }

        private void resimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlEditorKontrol.InsertImage();
        }
    }
}
