using System;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Test;

namespace iText.Layout {
    public class FloatTest : ExtendedITextTest {
        public static readonly String sourceFolder = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/layout/FloatTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/layout/FloatTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            CreateDestinationFolder(destinationFolder);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FloatParagraphTest01() {
            String cmpFileName = sourceFolder + "cmp_floatParagraphTest01.pdf";
            String outFile = destinationFolder + "floatParagraphTest01.pdf";
            PdfWriter writer = new PdfWriter(outFile);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            Paragraph p = new Paragraph();
            p.Add("paragraph1");
            p.SetWidth(70);
            p.SetHeight(100);
            p.SetBorder(new SolidBorder(1));
            p.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            Paragraph p1 = new Paragraph();
            p1.Add("paragraph2");
            p1.SetWidth(70);
            p1.SetHeight(100);
            p1.SetBorder(new SolidBorder(1));
            p1.SetProperty(Property.FLOAT, FloatPropertyValue.RIGHT);
            doc.Add(p);
            doc.Add(p1);
            Paragraph p2 = new Paragraph();
            p2.Add("paragraph3");
            p2.SetBorder(new SolidBorder(1));
            doc.Add(p2);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFile, cmpFileName, destinationFolder, 
                "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FloatParagraphTest02() {
            String cmpFileName = sourceFolder + "cmp_floatParagraphTest02.pdf";
            String outFile = destinationFolder + "floatParagraphTest02.pdf";
            PdfWriter writer = new PdfWriter(outFile);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            Paragraph p = new Paragraph();
            p.Add("paragraph1");
            p.SetWidth(70);
            p.SetHeight(100);
            p.SetBorder(new SolidBorder(1));
            Paragraph p1 = new Paragraph();
            p1.Add("paragraph2");
            p1.SetBorder(new SolidBorder(1));
            p.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            doc.Add(p);
            doc.Add(p1);
            Paragraph p2 = new Paragraph();
            p2.Add("paragraph3");
            p2.SetBorder(new SolidBorder(1));
            doc.Add(p2);
            doc.Add(p2);
            Paragraph p3 = new Paragraph("paragraph4aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
                );
            p3.SetBorder(new SolidBorder(1));
            doc.Add(p3);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFile, cmpFileName, destinationFolder, 
                "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FloatDivTest01() {
            String cmpFileName = sourceFolder + "cmp_floatDivTest01.pdf";
            String outFile = destinationFolder + "floatDivTest01.pdf";
            PdfWriter writer = new PdfWriter(outFile);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            Div div = new Div();
            div.SetWidth(70);
            Paragraph p = new Paragraph();
            p.Add("div1");
            div.SetBorder(new SolidBorder(1));
            p.SetBorder(new SolidBorder(1));
            div.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            div.Add(p);
            doc.Add(div);
            doc.Add(new Paragraph("div2"));
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFile, cmpFileName, destinationFolder, 
                "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FloatDivTest02() {
            String cmpFileName = sourceFolder + "cmp_floatDivTest02.pdf";
            String outFile = destinationFolder + "floatDivTest02.pdf";
            PdfWriter writer = new PdfWriter(outFile);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            Div div = new Div();
            div.SetMargin(0);
            div.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            Paragraph p = new Paragraph();
            p.Add("More news");
            div.Add(p);
            doc.Add(div);
            div = new Div();
            div.SetMargin(0);
            div.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            p = new Paragraph();
            p.Add("Even more news");
            div.Add(p);
            doc.Add(div);
            Div coloredDiv = new Div();
            coloredDiv.SetMargin(0);
            coloredDiv.SetBackgroundColor(Color.RED);
            Paragraph p1 = new Paragraph();
            p1.Add("Some div");
            coloredDiv.Add(p1);
            doc.Add(coloredDiv);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFile, cmpFileName, destinationFolder, 
                "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FloatDivTest03() {
            String cmpFileName = sourceFolder + "cmp_floatDivTest03.pdf";
            String outFile = destinationFolder + "floatDivTest03.pdf";
            PdfWriter writer = new PdfWriter(outFile);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            Div div = new Div();
            div.SetMargin(0);
            div.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            div.SetHeight(760);
            div.SetWidth(523);
            div.SetBorder(new SolidBorder(1));
            Paragraph p = new Paragraph();
            p.Add("More news");
            div.Add(p);
            doc.Add(div);
            div = new Div();
            div.SetMargin(0);
            div.SetProperty(Property.FLOAT, FloatPropertyValue.LEFT);
            //        div.setWidth(500);
            div.SetBorder(new SolidBorder(1));
            p = new Paragraph();
            p.Add("Even more news");
            div.Add(p);
            doc.Add(div);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFile, cmpFileName, destinationFolder, 
                "diff"));
        }
    }
}
