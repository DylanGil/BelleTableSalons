﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.IO;

namespace ppe1
{
    class CreatePDF
    {
        public static void generatePDF()
        {
            PdfDocument document = new PdfDocument();

            document.Info.Title = "Dylan Test";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Code 128", 60, XFontStyle.Regular);
            gfx.DrawString("informations de l'utilisateur", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
            const string filename = "BadgeUtilisateur.pdf";

            document.Save(filename);

            Process.Start(filename);
        }

        public static void generatePDFAll(string nom, string prenom, string departement, string email, string libelleSalon)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Badge de " + prenom + " " + nom + " - " + libelleSalon + "";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic); // definie la police
            XFont fontBarCode = new XFont("Code 128", 60, XFontStyle.Regular);

            gfx.DrawString(email, fontBarCode, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString(prenom +" "+ nom, font, XBrushes.Black, new XRect(0, 40, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString(departement, font, XBrushes.Black, new XRect(0, 70, page.Width, page.Height), XStringFormats.Center);
            string filename = "Badge de " + prenom + " " + nom + " - " + libelleSalon + ".pdf";

            document.Save(filename);

            Process.Start(filename);
        }

    }
}
