USING SYSTEM;
USING SYSTEM.COLLECTIONS.GENERIC;
USING SYSTEM.TEXT;
USING SYSTEM.IO;

NAMESPACE COPYFILEUPPER
{
    CLASS COPYFILEUPPER
    {
        PUBLIC STATIC VOID MAIN()
        {
            STRING SFROM;
            STRING STO;

            STREAMREADER SRFROM;
            STREAMWRITER SWTO;

            // GET INPUT
            CONSOLE.WRITE("COPY FROM: ");
            SFROM = CONSOLE.READLINE();

            // OUTPUT
            CONSOLE.WRITE("COPY TO: ");
            STO = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY FROM {0} TO {1}", SFROM, STO);
            TRY 
            {
                SRFROM = NEW STREAMREADER(SFROM);
                SWTO = NEW STREAMWRITER(STO);

                WHILE (SRFROM.PEEK() != -1)
                {
                    STRING SBUFFER = SRFROM.READLINE();
                    SBUFFER = SBUFFER.TOUPPER();
                    SWTO.WRITELINE(SBUFFER);
                }
                SWTO.CLOSE();
                SRFROM.CLOSE();

            }
            CATCH (FILENOTFOUNDEXCEPTION) 
            {
                CONSOLE.WRITELINE("INPUT FILE NOT FOUND.");
            }
            CATCH (EXCEPTION E)
            {
                CONSOLE.WRITELINE("UNEXPECTED EXCEPTION: {0}", E.TOSTRING());
            }

        }
    }
}
