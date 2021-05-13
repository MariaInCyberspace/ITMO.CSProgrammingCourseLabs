
namespace CSharp
{
    using System;

    public class HTMLTokenVisitor : NullTokenVisitor
    {
        // Add methods here

        private void FilteredWhite(IToken token)
        {
            string src = token.ToString();
            for (int i = 0; i != src.Length; i++)
            {
                string dst;
                switch (src[i])
                {
                    case '<':
                        dst = "&lt;"; break;
                    case '>':
                        dst = "&gt;"; break;
                    case '&':
                        dst = "&amp;"; break;
                    default:
                        dst = new string(src[i], 1); break;
                }
                Console.Write(dst);
            }
        }
        public override void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.Write("{0,3}", line.Number());
            Console.Write("</span>");

        }
        public override void Visit(ILineEndToken t)
        {
            Console.WriteLine(); // Not Write
        }

        public override void Visit(IIdentifierToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(ICommentToken token)
        {
            FilteredWhite(token);
        }

        public override void Visit(IKeywordToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(IOtherToken token)
        {
            FilteredWhite(token);
        }

        public override void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }
    }
}
