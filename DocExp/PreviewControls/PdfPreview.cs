using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Interfaces;

namespace DocExp.PreviewControls
{
    public class PdfPreview : AcroPDFLib.AcroPDF, IPreview
    {
        #region IPreview Members

        public void Preview(string path)
        {
            this.Preview(path);
        }

        #endregion
    }
}
