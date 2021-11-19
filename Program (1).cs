using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            //#1
            Console.WriteLine("Sind Sie bereit für den absoluten Wahnsinn? Können Sie dem Grauen widerstehen?");
            Console.WriteLine("Dann folgen Sie mir zu einem unvergesslichen Abenteuer!\n");
            Console.WriteLine("Jemand schlägt ihnen mit einem harten Gegenstand auf den Kopf, um Sie herum wird " +
                "es dunkel und Sie verlieren das Bewusstsein. ");
            Console.WriteLine("Als Sie wieder zu sich kommen, befinden Sie sich in einem schlecht beleuchteten " +
                "Raum auf einer Trage. Es ist kalt.");
            Console.WriteLine("Sie sind wider Erwarten nicht gefesselt. Sowohl an der linken, als auch an der rechten " +
                "Wand gibt es eine Tür.");
            Console.WriteLine("Hinter der linken Tür sind schleifende und kratzende Geräusche, sowie leise, " +
                "unverständliche Rufe zu hören. Hinter der rechten Tür hören Sie die Musik eines Blasorchesters. Wählen " +
                "Sie Ihren Weg nach draußen, wählen Sie weise!");
            Console.Write("Eingabe \"links\" oder \"rechts\": ");


            if (Auswahl("links", "rechts")) // linke Tür            erste Wahl -> zweiter Raum      #2
            {
                Console.WriteLine("Sie kommen in das Wohnzimmer einer normalen Wohnung und stellen fest," +
                    "dass die kratzenden Geräusche von einer Katze an ihrem Kratzbaum verursacht werden.");
                Console.WriteLine("Die Leisen Rufe kommen aus dem Fernseher, dieser läuft. Die Katze schaut sich " +
                    "die TV-Serie \"Friends\" an.");
                Console.WriteLine("Außer der Katze ist niemand zu Hause. Gegenüber des Fernsehgeräts steht eine " +
                    "bequem aussehende Couch.");
                Console.WriteLine("Möchten Sie sich setzen und mit der Katze fernsehen? So geben Sie \"setzen\" ein." +
                    "Wenn Sie sich lieber einen Kaffee aus der Küche nehmen möchten, geben Sie \"Kaffee\" ein. " +
                    "Wählen Sie weise.");
                Console.Write("Eingabe: ");

                if (Auswahl("setzen", "Kaffee")) //setzen zweite Wahl -> dritter Raum     #3
                {
                    Console.WriteLine("Sie sind großer Fan der Serie wie ich sehe. Ich auch.");
                    Console.WriteLine("Die Katze kommt zu Ihnen auf die Couch und macht es sich bequem. Was tun Sie " +
                        "nun?");
                    Console.WriteLine("Sie können die Katze streicheln und mit ihr zusammen weiter TV schauen. " +
                        "Ist es Ihnen aber eher unangenehm mit der unbekannten Katze, so stehen Sie auf und " +
                        "verlassen die Wohnung durch das Fenster.");
                    Console.Write("Ihre Wahl, \"streicheln\", oder \"Fenster\"? Wählen Sie jetzt: ");

                    if (Auswahl("streicheln", "Fenster")) //   streicheln            #4
                    {
                        Console.WriteLine("───────────────────────────────────────\n" +
"───▐▀▄───────▄▀▌───▄▄▄▄▄▄▄─────────────\n" +
"───▌▒▒▀▄▄▄▄▄▀▒▒▐▄▀▀▒██▒██▒▀▀▄──────────\n" +
"──▐▒▒▒▒▀▒▀▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄────────\n" +
"──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▒▒▒▒▒▒▒▒▒▒▒▒▀▄──────\n" +
"▀█▒▒▒█▌▒▒█▒▒▐█▒▒▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌─────\n" +
"▀▌▒▒▒▒▒▒▀▒▀▒▒▒▒▒▒▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐───▄▄\n" +
"▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌▄█▒█\n" +
"▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒█▀─\n" +
"▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀───\n" +
"▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌────\n" +
"─▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐─────\n" +
"─▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌─────\n" +
"──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐──────\n" +
"──▐▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▌──────\n" +
"────▀▄▄▀▀▀▀▀▄▄▀▀▀▀▀▀▀▄▄▀▀▀▀▀▄▄▀────────");
                        Console.WriteLine("Sie streicheln vorsichtig die Katze. Ihr scheint es zu gefallen und sie legt sich " +
                            "auf Ihre Beine.");
                        Console.WriteLine("Ganz ruhig schnurrend lässt sich die Katze weiter streicheln. Eine neue " +
                            "Freundschaft scheint zu entstehen.");
                        Console.WriteLine("Sie stellen leider fest, dass Sie allergisch auf Katzenhaare reagieren und erleiden einen anaphylaktischen Schock.");
                        Console.WriteLine("Sie spüren wie sich Ihre Bronchien eng zusammenziehen und sterben einen qualvollen Erstickungstod");
                    }
                    else //Fenster              #5
                    {
                        Console.WriteLine("Sie springen aus dem Fenster im 19. Stock. Warum genau tun Sie das? ");
                        Console.WriteLine("Sie haben natürlich nicht überlebt, nach kurzen 17 Minuten nach dem Aufschlagen erlöst Sie der Tod.");
                    }
                }
                else //dritter raum alternative Kaffee          #6
                {
                    Console.WriteLine("Sie gehen in die Küche und finden einen Kaffeevollautomat der Marke Jura." +
                        "Sie freuen sich auf ein absolutes Geschmackserlebnis.");
                    Console.WriteLine("Sie stellen fest, dass Sie keine Tasse dabei haben. Möchten Sie eine Tasse " +
                        "im Schrank darüber suchen, oder trinken Sie den Kaffee direkt aus dem Auslauf der Maschine?");
                    Console.Write("\"suchen\" oder \"trinken\"?: ");

                    if (Auswahl("suchen", "trinken")) //           #7
                    {
                        Console.WriteLine("Sie entnehmen dem Schrank eine große schwarze Tasse. Sie ist sauber. Sie stellen Sie unter den Auslauf der Jura-Maschine und starten diese.");
                        Console.WriteLine("Sie hören die interne Kaffeemühle, gefolgt von dem typischen Brummen eines Kaffeevollautomats.");
                        Console.WriteLine("Ein feines Kaffeearoma durchströmt den Raum. Die Vorfreude auf den Kaffee wächst mit der Füllstand der Tasse. Nach ein paar Sekunden ist die Tasse gefüllt.");
                        Console.WriteLine("   ;)(; \n" +
"  :----:  \n" +
" C|====|  \n" +
"  |    |  \n" +
"  `----'  \n");
                        Console.WriteLine("Sie entnehmen die Tasse und schlürfen direkt den ersten Schluck ab. Der Kaffee schmeckt großartig. Die Katze kommt zu Ihnen und zeigt auf die Tasse, begleitet von ");
                        Console.WriteLine("\"Miauuuuuuuuu\". Sie fragen sich, ob die Katze einen Schluck Kaffee möchte und halten ihr die Tasse hin. Tatsächlich führt die Katze ihre Zunge in den heißen Kaffee ");
                        Console.WriteLine("und beginnt diesen zu trinken. Sie wirkt äußerstt zufrieden. Kein Wunder, der Kaffee ist wirklich klasse.");
                        Console.WriteLine("Plötzlich beginnt die Katze gleißend hell zu leuchten, und auf einmal hat sie sich in eine wunderschöne Prinzessin verwandelt, die sich unsterblich in Sie verliebt hat.");
                        Console.WriteLine("Sie hebt ihre Arme in die Luft und dort, wo einst die Tür zur Küche war, öffnet sich ein Portal. Sie schreiten mit der Prinzessin hindurch und befinden sich nun in ");
                        Console.WriteLine("dem Palast der Prinzessin. Und Sie leben glücklich und zufrieden bis an Ihr Lebensende zusammen.");
                    }
                    else  //trinken          #8
                    {
                        Console.WriteLine("Erklären Sie mir mal bitte warum Sie brühend heißen Kaffee direkt aus " +
                            "der Maschine trinken. Natürlich verbrühen Sie sich den Hals, die Speiseröhre und " +
                            "den Magen.");
                        Console.WriteLine("Sie leiden so große Schmerzen, dass Sie das Bewusstsein verlieren. Nun " +
                            "werden Sie von der Katze gefressen.");

                        Console.WriteLine("░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░▄████████████████▄░░░░░░░░░░\n" +
"░░░░░░░░░░▄██▀░░░░░░░▀▀████████▄░░░░░░░░\n" +
"░░░░░░░░░▄█▀░░░░░░░░░░░░░▀▀██████▄░░░░░░\n" +
"░░░░░░░░░███▄░░░░░░░░░░░░░░░▀██████░░░░░\n" +
"░░░░░░░░▄░░▀▀█░░░░░░░░░░░░░░░░██████░░░░\n" +
"░░░░░░░█▄██▀▄░░░░░▄███▄▄░░░░░░███████░░░\n" +
"░░░░░░▄▀▀▀██▀░░░░░▄▄▄░░▀█░░░░█████████░░\n" +
"░░░░░▄▀░░░░▄▀░▄░░█▄██▀▄░░░░░██████████░░\n" +
"░░░░░█░░░░▀░░░█░░░▀▀▀▀▀░░░░░██████████▄░\n" +
"░░░░░░░▄█▄░░░░░▄░░░░░░░░░░░░██████████▀░\n" +
"░░░░░░█▀░░░░▀▀░░░░░░░░░░░░░███▀███████░░\n" +
"░░░▄▄░▀░▄░░░░░░░░░░░░░░░░░░▀░░░██████░░░\n" +
"██████░░█▄█▀░▄░░██░░░░░░░░░░░█▄█████▀░░░\n" +
"██████░░░▀████▀░▀░░░░░░░░░░░▄▀█████████▄\n" +
"██████░░░░░░░░░░░░░░░░░░░░▀▄████████████\n" +
"██████░░▄░░░░░░░░░░░░░▄░░░██████████████\n" +
"██████░░░░░░░░░░░░░▄█▀░░▄███████████████\n" +
"███████▄▄░░░░░░░░░▀░░░▄▀▄███████████████");
                    }
                }
            }
            else // rechte Tür          erste Wahl -> zweiter Raum      #9
            {
                Console.WriteLine("Sie betreten die große Halle der Stadthalle Merzig. Das Blasorchester der örtlichen " +
                    "Feuerwehr gibt ein Konzert.");
                Console.WriteLine("Sie finden Blasmusik echt zum kotzen. Neben Ihnen sehen Sie auf einem Tisch ein faules " +
                    "Ei, außerdem noch eine Flasche Olivenöl.");
                Console.WriteLine("Sie haben die Wahl. Sie können das Ei essen und die Flasche Öl austrinken. Oder aber Sie " +
                    "verlassen die Halle durch die Seitentür.");
                Console.Write("Sie wählen. Geben Sie \"essen\" oder \"Tür\" ein: ");

                if (Auswahl("essen", "Tür"))          //essen       #10
                {
                    Console.WriteLine("Ich weiß zwar nicht warum genau Sie scheinbar jeden Müll essen den Sie finden, aber es " +
                        "ist ja Ihre Entscheidung.");
                    Console.WriteLine("Beim Kauen fällt Ihnen der extreme Schwefelgeruch auf. Die Flasche Öl neutralisiert " +
                        "diesen ein wenig.");
                    Console.WriteLine("Nach einer halben Stunde wird Ihnen unwohl und Sie verlassen die Halle durch den " +
                        "Vordereingang. Ein wenig frische Luft tut Ihnen bestimmt gut.");
                    Console.WriteLine("Sie fühlen keine Besserung an der frischen Luft und fragen sich, ob sie vielleicht " +
                        "besser der Blaskapelle nicht zugehört hätten. Von Blasmusik wird Ihnen schließlich immer schlecht.");
                    Console.WriteLine("In der Nähe ist eine öffentliche Toilette, diese könnten Sie möglicherweise brauchen." +
                        "Sie könnten aber auch versuchen nach Hause zu laufen und sich auszuruhen.");
                    Console.Write("Was ist ihr nächster Schritt? Wählen Sie \"Toilette\" oder \"ausruhen\": ");

                    if (Auswahl("Toilette", "ausruhen")) // Toilette       #11
                    {
                        Console.WriteLine("" +
                            " __________________________________________________\n" +
          "~~<><><><><><><><><><><><><><><><><><><><><><><>~~!\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "  8888888888888888888888888888888888888888888888  !\n" +
          "   ~~~~~~~~~~~~~~~~~~~~~[]~~~~~~~~~~~~~~~~~~~~~   !\n" +
          "                        []                        !\n" +
          "                        []                        !\n" +
          "                        []                        !\n" +
          "                        []                        !\n" +
          "                        []                        I\n" +
          "                        []                        M\n" +
          "                        []                        W\n" +
          "                    ____[]___\n" +
          "             _mmm88888888888888mmm_\n" +
          "         _m8**888888888888888888888**8m_\n" +
          "       m8*8m*8m888***88~88~8***888m8*m8*8m\n" +
          "     m8888mm888*8m88888 88 8888m8*888mm8888m\n" +
          "    m8888888*8m88888888 88 8888888m8*8888888m\n" +
          "   m8888888*_8888888888 88 888888888_*8888888m\n" +
          "   88888888 88888888888 88 8888888888 88888888\n" +
          "   88888888 88888888888 88 8888888888 88888888\n" +
          "   ~88888888 8888888888 88 888888888 88888888~\n" +
          "    ~88888888m8*8888888 88 888888*8m88888888~\n" +
          "     ~*888888888m8***88 88 8***8m888888888*~\n" +
          "       ~*888888888888mmmmmmm888888888888*~\n" +
          "          ~**888~m=m=mmmmmmm=m=m~888**~\n" +
          "  ____________88_888888888888888_88____________\n" +
          " *888888888888888888888888888888888888888888888*\n" +
          "       mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm\n" +
          "       88888888888888888888888888888888888\n" +
          "        888888888888888888888888888888888\n" +
          "         *88888888*88888888888*88888888*\n" +
          "           ~*888888 888888888 888888*~\n" +
          "              ~**88 888888888 88**~\n" +
          "                8mm 888888888 mm8   \n" +
          "               _88* 888888888 *88_\n" +
          "          _____888_88888888888_888_____\n" +
          "         8888888888888888888888888888888");
                        Console.WriteLine("Sie bekommen den Durchfall Ihres Lebens, sie sprudeln wie ein umgestülpter Vulkan. " +
                            "Als ob das noch nicht reichen würde, fangen Sie an zu kotzen wie noch nie zuvor.");
                        Console.WriteLine("Sie fragen sich, was sie wohl falsch gemacht haben könnten.");
                        Console.WriteLine("Sie hören ein leises Geräusch vor der Tür. Bei dem Versuch die Tür ein wenig zu " +
                            "öffnen stellen Sie fest, dass jemand die Tür von außen verkeilt hat. Sie sind gefangen.");
                        Console.WriteLine("Aufgrund des üblen Geruchs verlieren Sie das Bewusstsein. Sie sterben aufgrund der " +
                            "massiven Dehydrierung kurz darauf auf der Toilette sitzend. Aber es wird auf keinen Fall daran " +
                            "gelegen haben, dass Sie ja unbedingt das faule Ei essen mussten.");
                    }
                    else //ausruhen         #12
                    {
                        Console.WriteLine("Sie kommen nur langsam vorwärts, denn es wird Ihnen immer schlechter. Sie spüren, " +
                            "dass Ihnen innerhalb der nächsten drei Sekunden massiver... leider zu spät.");
                        Console.WriteLine("░░░░░░░░░░░█▀▀░░█░░░░░░\n" +
"░░░░░░▄▀▀▀▀░░░░░█▄▄░░░░\n" +
"░░░░░░█░█░░░░░░░░░░▐░░░\n" +
"░░░░░░▐▐░░░░░░░░░▄░▐░░░\n" +
"░░░░░░█░░░░░░░░▄▀▀░▐░░░\n" +
"░░░░▄▀░░░░░░░░▐░▄▄▀░░░░\n" +
"░░▄▀░░░▐░░░░░█▄▀░▐░░░░░\n" +
"░░█░░░▐░░░░░░░░▄░█░░░░░\n" +
"░░░█▄░░▀▄░░░░▄▀▐░█░░░░░\n" +
"░░░█▐▀▀▀░▀▀▀▀░░▐░█░░░░░\n" +
"░░▐█▐▄░░▀░░░░░░▐░█▄▄░░\n" +
"░░░▀▀░▄BUX ▄░░░▐▄▄▄▀░░░\n");
                        Console.WriteLine("Durchfall, kotzen, alles in die Bux und aufs Hemd. Glücklicherweise ist es " +
                            "absolut dunkel, es ist tiefste Nacht und die Straßenbeleuchtung ist ausgefallen.");
                        Console.WriteLine("Nach dieser Entladung geht es Ihnen ein klein wenig besser. Sie beeilen sich und " +
                            "schaffen es tatsächlich unbemerkt nach Hause.");
                        Console.WriteLine("Sie werfen die Klamotten alle in den Müll, duschen schnell, nochmal aufs Klo " +
                            "und dann ab ins Bett.");
                        Console.WriteLine("Immerhin haben Sie überlebt, herzlichen Glückwunsch.");
                    }
                }
                else //Tür      #13
                {
                    Console.WriteLine("                                          MMMMMMMMMMM\n" +
"                                       MMMMMMMMMMMMMMMMM\n" +
"                                   NMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                                 MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                                MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                                MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                               MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                               MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMD\n" +
"                              DMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                              MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                              MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                             MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                             MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                            MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"      NM                  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"      MMMMM              MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"       MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"        MMMMMMMMMMMMMMMMMMMMMMMMMM8MMMMMMMMMIMMMMM8,. ...........OMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"           MMMMMMMMMMMMMMMMMMMMMMM..N. .....~MMMM...............:MMMMNMMMMMMMMMMMMMMMMMMMMMMM\n" +
"             NMMMMMMMMMMMMMMMMMMMMM.....:..DMMMMMNZ Z...........M$MMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                 MMMMMMMMMMNMMMMMMM....... 7 = MMMMMMO....Z.......MM7MMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                    MMMMMMMMMMMMMMMMM  Z...MMMZ.. ., M.., ........MMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                        MMMMMM.......DOM....N7..................MMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                           MMM....... M. ... .  ... ..............M...$MMMMMMMMMMMMMMMMMMMM\n" +
"                              ........... ........~. ..............M.. = ....+MMMMMMMMMMMMMM\n" +
"                              ......+.NMI~........ . ..............M.,.I...MMMMMMMMMMMMMMN\n" +
"                              ......$... ......O.................., .....$MMMMMMMMMMMMN\n" +
"                              .....M..........M M................8.OMMMMMMMMMMMN\n" +
"                               .. = 7I,,.,, IMI...M....................MMMMMMMMMMM\n" +
"                               .MMMMMMMMMMMMMMDDMM:, N..............DMMMMMMMMMMM\n" +
"                               NMMMMMNMM8. ......., ~............MMMMMMMMM\n" +
"                               MMMMM,:......::~..M8M8MM...............MMMMMM\n" +
"                               MMMM... . ........., MM..............MMMMMO$\n" +
"                               MMMMM... =.=. .. . . MM....... . ...MMMMMMM\n" +
"                                NMMMMMMMMMM ? ..O.? NM7....... ......MMMMMM\n" +
"                                 NMMMMMMMMMMMMMMMMM........  $ . ...MMMNMMM\n" +
"                                  MMMMMMMMMMMMMMM.........,, ......MMMMMMMM\n" +
"                                   OMMMMMMMM8, .... ., N.......:MMMMMMMMMMN\n" +
"                                    MMMMMMMM ? N. ...~MD.:MNI8MMMMMMMMMMMMMMMMMN\n" +
"                               MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                            NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN\n" +
"                        MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                     MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                    NMMMMMMMMMMMMNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n" +
"                   MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n");
                    Console.WriteLine("Sie verlassen unauffällig durch die Seitentür die Halle. Kaum dass Sie draußen sind, " +
                        "stehen Sie unmittelbar vor Chuck Norris. Er schaut Sie scharf an und hält Ihnen einen Finger hin " +
                        "und bittet Sie daran zu ziehen.");
                    Console.WriteLine("Nun haben Sie die Wahl. Sie können Chuck Norris' Anweisung folgen und an seinem Finger " +
                        "ziehen, oder sie ziehen an seinem Bart.");
                    Console.Write("Wählen Sie nun. \"Finger\" oder \"Bart\"?: ");

                    if (Auswahl("Finger", "Bart")) // Finger        #14
                    {
                        Console.WriteLine("In dem Moment als sie kräftig an seinem Finger ziehen, verpasst Chuck Norris Ihnen " +
                            "einen Roundhouse-Kick in den Bauch, danach furzt er.");
                        Console.WriteLine("Aufgrund der hohen Energie, welche ein Chuck-Norris-Roundhouse-Kick überträg, " +
                            "sterben Sie an inneren Blutungen.");
                    }
                    else //Bart         #15
                    {
                        Console.WriteLine("Sie scheinen das Leben einfach satt zu haben, oder warum ziehen Sie an Chuck " +
                            "Norris' Bart?");
                        Console.WriteLine("Chuck Norris ist begeistert von Ihrem Mut und läd Sie zum Essen ins Burger King " +
                            "ein.");
                        Console.WriteLine("\n" +
                            "" +
  "                                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                      \n" +
  "                              ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓                  \n" +
  "                          ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓              \n" +
  "                      ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓          \n" +
  "                  ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓       \n" +
  "                ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▓▓       \n" +
  "              ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓      \n" +
  "            ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓      \n" +
  "            ▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓         \n" +
  "          ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓          \n" +
  "          ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓           \n" +
  "        ▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓         \n" +
  "      ▓▓▓▓▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓       \n" +
  "      ▓▓▓▓▒▒▓▓▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓       \n" +
  "      ▓▓▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓       \n" +
  "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓        \n" +
  "    ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓  \n" +
  "▓▓▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓\n" +
  "▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▓▓\n" +
  "▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓  \n" +
  "░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░  \n" +
  "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓        \n" +
  "    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      \n" +
  "    ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓      \n" +
  "    ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░      \n" +
  "    ▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒██        \n" +
  "  ██████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████████      \n" +
  "  ████▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓████      \n" +
  "  ████▓▓██▓▓▓▓▓▓▓▓▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓██▓▓▓▓▓▓▓▓██████      \n" +
  "  ████▓▓██▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████      \n" +
  "  ████▓▓▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓████      \n" +
  "  ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓██▓▓████      \n" +
  "  ████▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓████      \n" +
  "  ░░██████████████████████████████████████████████████████████████████████████████████████████░░      \n" +
  "    ░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓        \n" +
  "      ▓▓▒▒▓▓▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▓▓        \n" +
  "      ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓        \n" +
  "      ▓▓▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓        \n" +
  "      ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓        \n" +
  "        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓          ");
                        Console.WriteLine("Sie haben sich für eine kleine Portion Pommes Frittes und einen Hamburger " +
                            "entschieden. Chuck Norris hat sich einen Big Mac bestellt, und hat ihn bekommen.");
                        Console.WriteLine("Außerdem hat Chuck Norris während der Wartezeit zwei mal bis unendlich gezählt.");
                        Console.WriteLine("Zum Abschied verpasst er Ihnen noch einen Roundhouse-Kick. Sie werden erst am " +
                            "nächsten Morgen im Krankenhaus wieder wach. Aber Sie leben, gratuliere.");
                    }
                }
            }
            Console.ReadKey();
        }
        static bool Auswahl(string s1, string s2)
        {
            string wahl = Console.ReadLine();
            bool auswahl = !(wahl.ToLower().StartsWith(s1.Substring(0, 1).ToLower()) || wahl.ToLower().StartsWith(s2.Substring(0, 1).ToLower()));
            if (auswahl)
            {
                Console.WriteLine("Sie können das nicht tun! Treffen Sie eine gültige Entscheidung!");
                return Auswahl(s1, s2);
            }

            return wahl.ToLower().StartsWith(s1.Substring(0, 1).ToLower());
        }
    }
}
