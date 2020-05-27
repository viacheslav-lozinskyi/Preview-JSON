
using System.IO;
using System.Text.Json;

namespace resource.preview
{
    public class JSON : cartridge.AnyPreview
    {
        internal static class CONSTANT
        {
            public const string EXTENSION = ".JSON";
            public const string HINT = "Tag type";
        }

        protected override bool _IsEnabled(string url)
        {
            if (File.Exists(url))
            {
                return Path.GetExtension(url).ToUpper() == CONSTANT.EXTENSION;
            }
            return false;
        }

        protected override bool _IsGeneric(string url)
        {
            return false;
        }

        //protected override bool _Activate()
        //{
        //    return true;
        //}

        protected override bool _Execute(string url, atom.Trace context)
        {
            var a_Context = JsonDocument.Parse(File.ReadAllText(url));
            {
                __Execute(url, a_Context.RootElement, 1, context);
            }
            return true;
        }

        private static void __Execute(string url, JsonElement node, int level, atom.Trace context)
        {
            //if (node == null)
            //{
            //    return;
            //}
            //if (string.IsNullOrEmpty(node.Name))
            //{
            //    return;
            //}
            //if (context.IsTerminated() == false)
            //{
            //    if (node.NodeType != XmlNodeType.Comment)
            //    {
            //        context.
            //            Clear().
            //            SetContent(__GetContent(node)).
            //            SetComment(__GetComment(node)).
            //            SetPattern(__GetPattern(node)).
            //            SetFlag((level == 1) ? cartridge.AnyPreview.NAME.FLAG.EXPAND : "").
            //            SetHint(CONSTANT.HINT).
            //            SetLevel(level).
            //            Send();
            //    }
            //    if ((node.Attributes != null) && (node.NodeType == XmlNodeType.Element))
            //    {
            //        foreach (XmlAttribute a_Context in node.Attributes)
            //        {
            //            if (context.IsTerminated())
            //            {
            //                return;
            //            }
            //            {
            //                __Execute(url, a_Context, level + 1, context);
            //            }
            //        }
            //    }
            //    if ((node.ChildNodes != null) && (node.NodeType == XmlNodeType.Element))
            //    {
            //        foreach (JsonElement a_Context in node.ChildNodes)
            //        {
            //            if (context.IsTerminated())
            //            {
            //                return;
            //            }
            //            {
            //                __Execute(url, a_Context, level + 1, context);
            //            }
            //        }
            //    }
            //}
        }

        private static string __GetComment(JsonElement node)
        {
            //switch (node.NodeType)
            //{
            //    case XmlNodeType.None: return "None";
            //    case XmlNodeType.Element: return "Element";
            //    case XmlNodeType.Attribute: return "Attribute";
            //    case XmlNodeType.Text: return "Text";
            //    case XmlNodeType.CDATA: return "CDATA";
            //    case XmlNodeType.EntityReference: return "Entity Reference";
            //    case XmlNodeType.Entity: return "Entity";
            //    case XmlNodeType.ProcessingInstruction: return "Processing Instruction";
            //    case XmlNodeType.Comment: return "Comment";
            //    case XmlNodeType.Document: return "Document";
            //    case XmlNodeType.DocumentType: return "Document Type";
            //    case XmlNodeType.DocumentFragment: return "Document Fragment";
            //    case XmlNodeType.Notation: return "Notation";
            //    case XmlNodeType.Whitespace: return "Whitespace";
            //    case XmlNodeType.SignificantWhitespace: return "Significant Whitespace";
            //    case XmlNodeType.EndElement: return "End Element";
            //    case XmlNodeType.EndEntity: return "End Entity";
            //    case XmlNodeType.XmlDeclaration: return "Declaration";
            //}
            return "";
        }

        private static string __GetContent(JsonElement node)
        {
            return "";//node.Name + (string.IsNullOrEmpty(node.Value) ? "" : (" = " + cartridge.AnyUtility.GetCleanString(node.Value)));
        }

        private static string __GetPattern(JsonElement node)
        {
            return "";// (node.NodeType == XmlNodeType.Attribute) ? cartridge.AnyPreview.NAME.PATTERN.PARAMETER : "";
        }
    };
}