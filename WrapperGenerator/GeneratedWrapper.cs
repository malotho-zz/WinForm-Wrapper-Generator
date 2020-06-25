using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Squishyware.Text.SyntaxHighlighting;

namespace WrapperGenerator.UI
{
	public partial class GeneratedWrapper : Form
	{
		#region Constructors
		internal GeneratedWrapper (string source, Language language)
		{
			InitializeComponent ();

			string filePath = Path.Combine (Environment.GetEnvironmentVariable ("temp"), "WrapperGenerator.htm");

			SyntaxType syntaxType;
			if (language == Language.CSharp)
			{
				syntaxType = SyntaxType.CSharp;
			}
			else if (language == Language.VBNet)
			{
				syntaxType = SyntaxType.VisualBasic;
			}
			else
			{
				throw new ArgumentException ("Specified language is not supported: " + language);
			}

			Hashtable properties = new Hashtable ();
			properties["useLineNumbers"] = false;

			SyntaxHighlighter syntaxHighlighter = SyntaxHighlighter.GetHighlighter (syntaxType, properties);
			string html = syntaxHighlighter.Highlight (source);
			File.WriteAllText (filePath, html);

			this.webBrowser.DocumentText = File.ReadAllText (filePath);
		}
		#endregion
	}
}