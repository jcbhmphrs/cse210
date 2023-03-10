using System;
class Program
{
    static void Main(string[] args)
    {
        void Animation(int duration)
        {
            int AnimationStartingLine = Console.CursorTop;
            string[] frames = { """
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                               
                                                                                                                                                                               
                                                                                                                                                                               
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                        XkxxxxxkK                                               
                                                                  NKKKKKx;.....,dKKKKN                                          
                                                                WWk,....;oxdddxxc'..'dNW                                        
                                                               Xd;,.....'::;';dkxooool:lK                                       
                                                             0dl,.....'';ll;.',;ldxkko,;loOW                                    
                                                            Wd. ...''',,:ll:,'..';:dkxdl. cN                                    
                                                          WNXo. ..',,,,',,,,,,,,. .lxxxo'.cKNW                                  
                                                          Kc''....',,'..,odddl;'..',;;;;'',';O                                  
                                                          0, .........;cokkkkxol;''',cxx:,. .k                                  
                                                          0,  ..  .;;;::lkkoc::::::,'cxd:'. .k                                  
                                                        NKx'     .;dko' .od,...':ol:,,'',,. .k                                  
                                                   WWWWNd'..    .'...   .',,,c0Xl..cxc',lxc.'k                                  
                                                  Nx:;;;,',cl'  .,.     .',lxOXNl  .';oo;'lOKN                                  
                                             Nkoooo:,,;;'.':lc:,...   .''';d0KXXc .,c:;:od0W                                    
                                        N0OOOx:..',coxkkc,'.'cko.    .';,,;d0KKKo,;okdcoK                                       
                                      WNO;...'clodxkkkkkkkl. ;xl. ..... ..,o00OO00OlckXNW                                       
                                     Wx,'..;odxxl;:okkkkkkl. .;,. .,,,... .lKx,.l00OOo;c0                                       
                                     Wo. ..;clxkdolc:lkkl,.  .'.  'loool;..;lloollc:;okON   WOlcccccdX                          
                                     Wo. ..'';collc'..;:'..   ....,looxkdc:,';lo;..';lxkX Xkxdl,. .:oxxKW                       
                                     Wx;,'....',;:;,''''...  .....',,;ldxkxc'.....'co;..dKd..dNk. lWKl,d0XN                     
                                      WNO, ...''oXNXXXXK:    ,do;''..',;cdxc,...;xo'.  .... .lXx. lNWNXd.;0                     
                                        0,   .lk0WWWWNXK:  ..';:lo:'...'';;...,:okd,.,llll:..oKd. cKNWWd.'O                     
                                        Nkd;..dKXWWWWWNK:  ....';ccllccc;......';c:,';llll:''dKOdlc:l0No.'O                     
                                          Wd..dKXWWWWWNX:  ......';loooo;  ...   ..','',,,'.':okXNd,;ldl:oK                     
                                          Wk',dOKNWWWX0k;..cl,...',,,,,,.   ....   ........... .dOOOd;'dN                       
                                           NXOc'l0XXXx'.,:ldxxdc..,odddd:..;dddo,         .''. .....:kXN                        
                                             W0kd:;;;,,;lxxkkkko. ,xkxc,;cldkkkkdlccc'    ;kOOkkkkkk0N                          
                                                Koc' .',;:lxOkko. .:::,':xOkkkkkkkkkkc. ..:dkX                                  
                                                NKO:.    ..coool:,,,,;::coodxkkkkxxdo;..,:'..k                                  
                                              WWk,......','....,ONNNWKl....:loxkdl:...,;ox:..k                                  
                                             Xd;,.....',cdool' ,0    WX000Ol........':odxkc..k                                  
                                           0dl,....'';lodkkkx; ,0       Xxo;.......:ldkxol, .k                                  
                                        N0Ol.....'';coxkkkxdo, ,0       O' ......';okkkx:',:l0                                  
                                        0;......';:okkkkkkd:,'.cK     NNk' .....,;cdkxxo' cX                                    
                                        0, .....:dxxkkkkkkl..oKXW    Nd,'.......:dxxko:,. cN                                    
                                   Koccc;.    ..'cldkkkxol;..dW      Nc  .......;cccc;..  .:oK                                  
                                W0xl'.............'lkkkx:.,co0       Nc  .......'''.....','.'lxON                               
                              NKO:........',::::,..:oodo, :X         Nc    ......... .;cdkdc:'.:kKN                             
                            WWk,........',;lxxxxxxo,..,,..cX         Nc  ...       ..:dxkkkxxc;,.'xWW                           
                           Xd;,.........,ldxkkkkkkx:'...o0KW         Nc  ..........',cxkkkkkkxdl,',;oK                          
                           K:  ..........,;;;;;;;;,... .k            Nc  ............',;;;;;;;;,... ,0                          
                           K:...........................k            Nl.............................;0                          
        """, """
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                      
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                               
                                                                                                                                                                               
                                                                                                                                                                               
                                                                                                                                                                              
                                                              WWWWWWWWW                                                         
                                                             Wk:;;;;;;oK                                                        
                                                        WOooool:::::::cooooxX                                                   
                                                      X0k:....:dolldkkd:''';dOKW                                                
                                                   WNXx'.....',:,..;odxxxkkx;.lKNW                                              
                                                   Xl''....',;ldl;'...'codkxoc:,;O                                              
                                                   K: ...'',,;;:;,'.....'cxkxx:..k    0lcccccoK                                 
                                                 Kkd,....','.............,looo:.'lxxxxo:::cccldx0W                              
                                                Wd........'.  ......''''''',:c:,'.    cKXWWWWXl'l0KN                            
                                                Wd. ...      .cO000KXXO,..';xKx;'.   .lXNWWWWWK0o',k                            
                                                Wd.        .oxOKXNNWWWN0kc..;c:'.. .dkl,c0WWWWWNd..k                            
                                                Wd.    ..  .clllxXWWWWWWWd. .',cc. .;ccccclccoONd..k                            
                                                WOc;. .... .....;xOXWWWNNo  '::cc'..  ,oo:;,,,cdocl0                            
                                                   K:    .......'',dKXK0Ol..cd:. .,'... .dK0Od'.cX                              
                                                   K:    .....',:odc;;,..:xd;...'','..........  cN                              
                                                W0l:.  ....'',codxx:...:olll:,'.......'',:ccc:. cN                              
                                              NOxo;'. .....,cldkxdl'  .dKkol;,,,,,,'..',:dkxoc. cN                              
                                              0,.:ko. .....:dkxdl,'...,okkxo' 'dkkkd:,,';okl,,,;dN                              
                                              0, ;kd' .....;dxl;'. :kkxc,'..  'dkkkkxx; .lx:.'kNW                               
                                              0, :kkdo;....,::'.   .;;,..'cc. .loooooo, .,:' 'O                                 
                                              Nkdl::odc,'..........,cc:'.',,. ..''''''.  ..:dkX                                 
                                                 Oc::;;;,.   ...',;lxkxlc' .,:::::::::::::ckW                                   
                                                   K:      .....',,cdddxd: 'O             W                                     
                                                   K:............'',,,;;:'.'O                                                   
                                                   W0kl..,:cllllloooloc'.cxON                                                   
                                                      k'.'::lllllllccccloOW                                                     
                                                   WXKx,.......'',,.  'xKXW                                                     
                                                   Xc..''''...',:dx;  ..'dNWWWW                                                 
                                                   K: .:cld:...,:dk;. .;ol:;;:xN                                                
                                                   K: ,oxkkdc;'..,;;::cdkd::::lodK                                              
                                                   K: ;xkkkkkx;    ;dxxkkkkkkkc..lOKW                                           
                                                   K: ,xkxxxxd,    .::loddddxxc. ..:K                                           
                                                   K: 'll:,,;,'..   ........',,''. :K                                           
                                                 0l:,..,,,';ll:,.      ......',,,. :K                                           
                                              NOxc.....',:coxxl;'   ......'',,,''. :K                                           
                                           WNKk,.....',:cdkkkxl;.  .....'',,,,'..,,oX                                           
                                          WNd......',;cxxkkkkxc,.  ....',,,,,,. .xNWW                                           
                                         Kl;.  ....,ldxkkkkkkx;........,,,,,''. .k                                              
                                      WOoc'.   ....,okkkkkkdlc'  ......',,''..;oxK                                              
                                      Nc .... .....,coxkkdoc'...............  cN                                                
                                    WNKc........ ...',:do:,.  ....           .cKNW                                              
                                    O;''....',,,'.  ...... .  ...'''''''''''..'';O                                              
                                    k. ...',coooolcccc;..  ;xkc...'',,,,,,,,,'. .k                                              
                                    k. .';cldkkkkkkkkko;'. cNWOoc'..''',,,,,,,'..lx0N                                           
                                    k. .,cxkkkkkkkkxxdc,,,;dN   Kl,''...'',,,,'... :X                                           
                                    k. .,cdxkkkxxxxd:;'.,ONW    WWNd,.......','....cX                                           
                                    k. .',:cdkdl:;'...cOKN         NK0000o.......o0KW                                           
                                    Xxo;....';,..cdddd0W                 KxdddddxK                                              
                                      Nl.........dW                                                                             
        """, """
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                        
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                       
                                                                                                                                                                               
                                                                                                                                                                               
                                                                                                                                                                               
                                                        WNNNNNNNNNW     WNNNNNNNW                                               
                                                       Wx,''''''',xW    0:''''';kW                                              
                                                     KocdxddddddooocccccloodddoolcdX                                            
                                                  W0xdccOWWWWWWNXKl   .,;co0WWNXc ,0                                            
                                                  Nc.,OKXNX0OOOOkx:. .:d:..cO000c.,kKN                                          
                                                  Nc ,OKKKx'.......'',,,,''...,;;,,..dW                                         
                                                  Nc ,O0l',clllc,'.......',lko..;oc..oW                                         
                                                Kdl;..;:'..:ldkxol,   .....:dc. ;xd,.:oxX                                       
                                                k. .... ...',lxkkkl,''..'''...  ;xxlc' 'O                                       
                                                k. ......  .':dxkkkkkd' 'lo,..  ;dxxx:.'O                                       
                                                k. ...,'.  ..,;cdkkkkd'  ..:d:. .;cdk:.'O                                       
                                                k. ..',,......',:cccc:. .cl:,.   ..',. 'O                                       
                                                Koc,..,,...',...........:O0d;'  .,,,,. 'O                                       
                                                  Nc ..'..,dkc.....   ':o0KKKd. ;kkdoc;c0                                       
                                                 WXc   .,coxkkxxdd;  .l000000d. ;xd;'oXWW                                       
                                                0c;,'. .:xxkkkkd;..  .oKx;';c;. .':k0XW                                         
                                                k. ;l; .ckkkkkko.    .;olc:'.;odddkN                                            
                                                k..ckc..:xxkkdlc,'.   ..;lol:dX                                                 
                                                O,'cd:..,cldd:.'ld;       .kW                                                   
                                                WX0l..''.....;ol;,.   .'. .k                                                    
                                                  WKko'.     .''..':cclo:'':cxN                                                 
                                                     O'  .........:xkkkko;,. :K                                                 
                                                     0c,'.......',:oooddl;,. :K                                                 
                                                     WWXo.....''''',,,,,,,,..cX                                                 
                                                       WX0x,.,oooododood:..o0KW                                                 
                                                       W0oc,.,cccccccccc, .k                                                    
                                                       Wo..;c,.';:::;;... .k                                                    
                                                       Wo..ldc,;dkkkkd;....xXNW                                                 
                                                       Wo..',cdxkkkkkkxdoc:;'lX                                                 
                                                       Wo.  .:kkkkkkkkOko,...,:l0                                               
                                                       WOo:. ,dxddoc::::,..;l;..dW                                              
                                                          0, .;:::'.   ..;cdkl..dW                                              
                                                     WWWWW0,      ...',,cdxxkl..dW                                              
                                                     Kl;;;;'......,looddxkxoc,..dW                                              
                                                  WOoc'.   .....''cxkkkkkkx:.. .dW                                              
                                                  Nc ....  ....':coxkkkkxdl'   .lO0N                                            
                                                  Nc  ...  ....,ldxkkkxxl;'. .....;0                                            
                                                  Nc  .....  ..';:lxkxl:'.....',. ,0                                            
                                                  Nc  .............','......',,,. ,0                                            
                                                  Wkl:'...':c:,,,,'...  ..',,,,,. ,0                                            
                                                     O' ..;dkkkkkkdc:;. .',,,,,'. ,0                                            
                                                     O,...;dkkkkkkkxko' .',,,,....;0                                            
                                                     NKOc.'okkkkkkkkkd' .',,,'..l0KW                                            
                                                       Wo..:ldkkkkkkkd' ..',,. .dW                                              
                                                       Wkc:,':odxkkkkd'  ...,. .dW                                              
                                                          Kc'',;oxxkkd'    ....,kW                                              
                                                          WXKo..,:lxkd' ..'..;OXN                                               
                                                            Wd. ...',''.',,. :K                                                 
                                                             0oc.  ...',,,,. :X                                                 
                                                               K: .',,,,,,,. :K                                                 
                                                               Xc.....',,,,. :K                                                 
                                                               WK0o....'',,. :K                                                 
                                                                  Kxdo;...'cdON                                                 
                                                                     Nl....k                                                    
        """, """
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                          
                                                XkxxxxxkX    KkxxxxxxON                                                         
                                             WXKx;'',,,:xKXWWk,''',,,ckKXW                                                      
                                           WWKc'cOKXXXNXo'lKWKO0XXXNNKc'oXW                                                     
                                           O::ox0NWWWWWWKOxc;dKXWWWWWNOxo:c0                                                    
                                          Wd..xXNWWWWWWWWWO. cKXWWWWWWNXd..k                                                    
                                          Wd..xX0kkkkkkkKNk. ,odxkkkkxdd:..k                                                    
                                          Wd..oOc.   ...l0o.  ........... .xXNW                                                 
                                          Wd.......',:ooc;'  .:codddoddd;. .,lX                                                 
                                           XOd, ..'codkxc,.  .:cxko;,,,,'....,cl0                                               
                                             K: ..,okkkkdl;. .,;:c:;;;,,'..',,:ldxON                                            
                                             K: ..,okkkkkkl. .''..cxkkkko'...:k0c.,0                                            
                                             Xc...'lkkkkkkl.   .lxxkkkkkxxd,..,,. ,0                                            
                                             WK0o..,coxkoc,. .;cxkl''...;odoo:.   ,0                                            
                                                k. .',;;'..  .',,;:oooooc,',;;;;. ,0                                            
                                                0l:,.....''''.    :XWWWWx. .,;clc:oX                                            
                                                  Xc .codkkkk:.   :0XXNWk'.oKx,.dXNW                                            
                                                  Nc .coxkkkkdc;. :0KKKX0Ok0K0Okl,cK                                            
                                                  Nc .coxkkkkkxl. .cloOKk:;;;lOKc ,0                                            
                                                  Nklc;;okkkkkko.  ..'dKo.  ..:oolxX                                            
                                                     O'.:xkkkkko.  ..'lxl'';:,..dW                                              
                                                     O' ,loxkkko. ,dxo'.,xOOOd'.xW                                              
                                                     O' ..,ldddc. ,xkd' ..'''ck0N                                               
                                                     O' ...''''.. ,xkd' .,;'.;ld0                                               
                                                     Ko:;'...   ..,clc'.;xkoc;..lOKN                                            
                                                       Nd'',,.  .'.  .';cxkkkd:,..;0                                            
                                                        NXk;..    ....';cxkkkd:,. ,0                                            
                                                          N0kc. ......'',::::;,'. ,0 0ooK                                       
                                                             0oc,..,;;::ccccc;..  .oxo::ox0W                                    
                                                               K: 'cloxkxooooc'..... ;xd,.cOKN                                  
                                                             WWK: 'clodkl....,oxxxl. ;xxc;,.,k                                  
                                                            WO:;'..,,,;:clooodkkOOo. ;xkxd:..k                                  
                                                            Wd. .''..':lokkkkkkko;,'.:xkkkc..k                                  
                                                            Wd. ';,..,okkkkkkxol,..;cokkxd:..k                                  
                                                            Wk,',,''',lxxkkxdc...;cdkkkxc,,';O                                  
                                                             NXO:..,,,,,cxx:....:dxkkkkd,.c0XW                                  
                                                            W0lllc;......',....'ckkkkdl:. cN                                    
                                                            Wd..lkc.   .........'::::,.'clkW                                    
                                                            Wd..lkc.  ..',,'........   'O                                       
                                                            Wd..lx:   ..',;lxxxxxxo:,. 'kWW                                     
                                                            Wd. ...   ..',;okkkkkkkxdc,,;:xN                                    
                                                            Wd. .........',:loxkkkkkkxoc. cN                                    
                                                          N0Ol....''''.......;ldxkkkkkkd;.:k0N                                  
                                                          0;.....'',,;;,.    .',cddxxxxdc;'..k                                  
                                                          0, ..',,,,;;;;'..   ....',,;::;;'..k                                  
                                                       WOl:'...',;,,,;;;,'.. ,dkkkd;......:xOX                                  
                                                     Xkd;  ....',,,;,;,;'..:lkN   NkllllllkW                                    
                                                  WXKx'.   ....',,;;;;,,. .k                                                    
                                                  No.....  ....',,,,,,''..'k                                                    
                                                  Nc  ...  ....',;,''...:OKN                                                    
                                                  Nc  ..........''....  cN                                                      
                                                  Nxc,. .,'.........    cN                                                      
                                                     O' ...,,.    ..'.. cN                                                      
                                                     O'   .';,'''',,,'. cN                                                      
                                                     NOx:. .',,,;;,,;,. cN                                                      
                                                       Wo. ...',,,,;;,. cN                                                      
                                                       Wx;'. ...,,;;;,. cN                                                      
                                                        WNO;.. .',,;;,. cN                                                      
                                                          NK0l. ...,;,. cN                                                      
                                                             Kxl'  ..'ld0W                                                      
                                                               K:....'O                                                                                                                                                                                
                                                                                                                                                                      
                                                                                                                                                                      
                                                                                                                                                                      
                                                                                                                                                                      
                                                                                                                                                                      
                                                                                                                                                                      
        """, """
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                               
                                                                                                                                                                              
                                                                                                                                                                                  
                                                                                                                                                                           
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                                  
                                         WNNNNN                    WNNNNNNNNW         WNNNNW                                    
                                         0:'',oX                  Wk:;,,,,':0        Wk;'',xW                                   
                                      Nkcoxxxxdll0           WOlccclllcccccllcccoK XdclooooocoK                                 
                                    XkxocxNWWWKoldxON      Xkd:....,looccokxc,,,:oxdl:xKXXNklldx0W                              
                                    k..xWWWWWWWWWo.,0   WXKx'....'';::;..,ldxxkkx:.,okkk0XNWWK:.lN                              
                                    k..xWWWWWWWWNl ,0WW No......',;cddo:,...;ldkkdl;...':kKXWK; cN                              
                                    k..dXNWWWWWNXc .,:kWXc  ..',,,;;;;;,''''..;xkkxl.   .,:dX0; cN                              
                                    KxdlcdKNNN0l:::;'.:ol;....,,,..;ccllc:,'..'clll:..   .';:cod0W                              
                                      Nxclodddc..:kxoc'  .......'',lkkkkkd:;,'',,:lc;'.  .';:oK                                 
                                         O'   .',cxxkk:. ...  ..'ldxkkkxdddo:,,',dKk:'. ..'dN                                   
                                         O' ....',:cdkc.      :ko'.cxkd,....cdl,';:;'.. 'kXN                                    
                                         NOxc....''',,;cc:;'..';'  .:c:'.;dd:,:ll;',cl' ,0                                      
                                           WOoc'.';;;;lkkxdc'.     .'';cokNK; .;cccc:cllxX                                      
                                              Kl;::cdkkkkkko'.     .'':kKXNK;  .':ol::kW                                        
                                              WWNd'':ldkkkkkxd,    .'':kKKXO; ,xk:.cKNW                                         
                                                 X0k:.;odxkkkx;    .'':kKKKKkdolok0KW                                           
                                                   K: .',ldddo, .,;'..,xKxclkKOxddokN                                           
                                                   K: ..',;;;,. .:c,...lkl;;oxxddlcdN                                           
                                                   Xl':ol.       ...''',,lkkc'. .kW                                             
                                                   WNXx,..  ...';lddddo;'';,.   .k                                              
                                                      XOx;  ..',cdkkkkxolllllc, .k                                              
                                                        Nc  ..'';loollllllllxkc..k                                              
                                                        Nd;,'...',,,,,,;;;;;coc;:O                                              
                                                         WNk,....'';clodxxkd,.cKNW                                              
                                                           NKOc..;coxxxkkkkd' cN                                                
                                                             Wo..,;:ccccccc:. cN                                                
                                                           N0kc..........,;,. cN                                                
                                                           O,..'',,,,,,,,:ol. cN                                                
                                                           O' 'cldddddddd:..  cX                                                
                                                           O' ,lokkkkkxl:,..  .:o0                                              
                                                           Kdlc;:oxollc,.'''... .cxON                                           
                                                             Wo..,:,...'',::::'  ..cOKN                                         
                                                            WNo.   ...',;lxxxxc. ;dl''xWW                                       
                                                           Kl;,.....',;ldxkkkkc. .....,;oX                                      
                                                        WOo:. .....;lloxkkkxdl;   ..... ,0                                      
                                                      N0k:.   ....'cxkkkkkkx:'....''... ,0                                      
                                                      k.....  ....'cxkkkkkxo' ..',,,....:K                                      
                                                      k. ...  ....'cxxkkkoc;. .',,;'..oKXW                                      
                                                      k. ..........;cclxkc.....,,,'. .dW                                        
                                                      k. .............';:'  .',,,..,co0                                         
                                                      O:,'..............    .,,,'. :K                                           
                                                      WWKc......',;ldxo:,.  .,,'...cX                                           
                                                        Nc .....,ldxkkxdd;  .'...o0KW                                           
                                                        W0dl'...;dkkkkkkk:.  .  .k                                              
                                                           O' .';dkkkkkkk:.  .  .k                                              
                                                           0;.',:oxkkkkkkc. .,. .k                                              
                                                           WXKl..;:oxkkkk:. .,'..k                                              
                                                             Wo..';lxkd:,'....:xOX                                              
                                                             WOoc,.,::;...,,. cN                                                
                                                                0,    ..'',,. cN                                                
                                                                0;.....',,;,. cN                                                
                                                                WK0l'...',,,. cN                                                
                                                                   Kxxo,...,ld0W                                                
                                                                      K:   'O      
                                                                                                                                                                      
                                                                                                                                                                      
                                                                                                                                                                      
        """, """
                                                                                                                                                                                
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                         
                                                                                                                                                                                
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                  X0OOOOOO0N                                                    
                                                             WNXNNx,......,xXNNNW                                               
                                                            Wk;'',:odddddddc,,';kW                                              
                                                          Xdc;....,clc;,cxkdcccllcdX                                            
                                                       WKko,...''';clc'.':coxxkkl';oxKW                                         
                                                       Wo.....'',;codo:,...':lxkxoc..oW                                         
                                                      WNo. ..',,,,,,,,,'','. 'okkko..oNW                                        
                                                     Kl;,....','..,oddddc,'..';:::;'',;lK                                       
                                                     O' ........,:okkkkkxlc;''',cdo:,. 'O                                       
                                                     O' ...  .,;cldkkkollllc:;''lkx:'. 'O                                       
                                 NNNNNNNNNNNNNNNW    O'      :kd. ,dkd' ...:dl;,,,,,'. .kNNNNW                                  
                                Nd,'''''''''''',xW   O'    .....  .;;;,'cOOc.,ld:',ld;...''';O                                  
                               WOooooooo:. ..':cllccc;. 'c:;,.    .'';ldONNc ..,:ol;,'....,oxocxN                               
                               WkkNNNNNN0l;'.,okl..  .,;::ccc,..  .',;xKXNK: .,:::;..',,'.lXNkcoxkK                             
                               WkOWWWWWWWNXc .lko;,. 'dxc.,colc,. .',;xKKK0l';dk: .',,,,'.lKWWWO'.dW                            
                               WkOWWWWWNNWNl .lxl;'. ,dkxxl..:xo. .'';xKK0000xc;'.......''c0XNNO,.xW                            
                               WkOWWWNd,c0Xc  ';'..,:lxkxd:. ;ko.   ..dKx;,dK0Ox:.......ckOKKo;lk0XW                            
                               Wd:lcclcccc:.   .:do:,,;;,'.  .;,......:olcclolccodddddddlc::codON                               
                               Wkc:,. ;doc:::::ckWNxc,.      ...;c::;;,':dd:'. .dW     Nxc::l0                                  
                                 W 0;..'lX WW  W     O' .....',:dkkkkxc,,,,,,. .dW                                              
                                   WXXXXNW           O'......',:dkkkkxxddddddc..dW                                              
                                                     NOxc....'',;::::::::::cc;..dW                                              
                                                       WOoc'...',;::cccccc:,.,co0                                               
                                                          0, .';loxkkkkkkkx; :X                                                 
                                                          0, 'cldxkkkkkkkkx, :K                                                 
                                                          0, .,,;;;;:;;;,'.. :K                                                 
                                                       W0dc'....',;cllll;..  'looooooooxX                                       
                                                       Wo..';;:;,,:oodxko,.'''''''..  .'dOKW                                    
                                                       Wo..:odkd:,,,,;oxc..ckkkkkko. .,,..lN                                    
                                                       Wo..:odkkxdc'.';:'..ckkkkkko. .,,. cN                                    
                                                       Wo..:odkkkkc.....':ldkkddc,,'.',,. cN                                    
                                                       Wo..:odkkkkc.    .;::::,,...',,;,. cN                                    
                                                       Wo..:odkkkkc.           ..,,,,,',,;dN                                    
                                                       Wo..:odxkkx:   ........',,,,,,. 'kNW                                     
                                                       Wo..:l;'''..   .....',,,;;;,;,. 'O                                       
                                                       Wo. .'...,:.   .....',,,,;;,..:dkX                                       
                                                       Wo.  ..';dkc................ .oW                                         
                                                       Wo. .',;cdko:;,.  ...        .oW                                         
                                                       No..',cdxkkxxxo'    .''''''. .oW                                         
                                                     Koc;..,;lkkkkkkkd'  ..',,,,,;'..oW                                         
                                                     O' ..',;lkkkkkkkd'  ..',,,,,;'..oW                                         
                                                  WXKx'...',;lkkkkkkkd'  ..',,,,,;'..oW                                         
                                                  No......',;lxkkkkkkd' ...',,,,,;'..oW                                         
                                                  Nc  .....'';:lxkdcc;. :OOc..,;,;'..oW                                         
                                                Kdl'  ..........,;'...  cNW0dl,...,ld0W                                         
                                                k.   ......... .......  cN   Xo:::dX                                            
                                                k. ...     ...',;;:;;,. cN     WWW                                              
                                                k.........,lddddxxdxxo' cN                                                      
                                                XOx:......;dkkkkkkkkkx:';coK                                                    
                                                  Nkl:'...,coxkkkkkkkxc;. .k                                                    
                                                     0c,'..',cdxxkkkkxc;. .k                                                    
                                                     WWXo....';:dkkkkxc;. .k                                                    
                                                       WX0x,....;cokkxc;. .k                                                    
                                                          Nkdddo;.',;,..;oxK                                                    
                                                               K:       cN                                                      
        """, """
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                               
                                                                                                                                                                                 
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                         
                                                                                                                                                                                 
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                WXKKKKKKKNW                                                     
                                                            WWWW0:......'dNWWWW                                                 
                                                           Kl;;;:loooooool:;;:xN                                                
                                                        WOoc.....:lc:;cdkd::::lodK                                              
                                                      X0k:.....',:c,...:loxxkko''oOKW                                           
                                                      k.......',:odc;,'..':ldkxol,.:X                                           
                                                      k. ..',,,,,,,,'''''...lkkkx, :K                                           
                                                   Nxc;....',,..'cooooc,'...;cccc,.,:l0W                                        
                                                   K: ........';cxkkkkxl:;''',:lo:,. .dW                                        
                                                   K:  ..   .':odkkxoooooc;,,'ckOl'. .dW                                        
                                                   K:      'xk;.'ok:.....;dd:',;;,'. .dW                                        
                                                   K:    ...''. .;:,..,okl''cdc''cd:..dW                                        
                                           W0ooooooc' .;;...    ..,:ooxKWd. .;:cc:;coxK                                         
                                      WKOOOOl,''''''..,cc,'.    ..,o00KXNo. .,;clccdX                                           
                                    WNKc....:dxkkkkxol;..ckc.   ..,o00KKKo..oOl..dXXXNW                                         
                                    O;',,;oo;.,dkkkkkk:..ckc.   ..,o00KKK0kxl:'  .',';kW                                        
                                    k. .;cxx, ..,cddkkc..ckc. .....l00Ol;o00kx:. 'cc;;cccccccoK                                 
                                    k. .',:::cccc;,,:::;;::,..,l;. ,odoc;cddol:''lkd:,;;;;;:cldx0W                              
                                    k. ....'xWWWWd'.  'lc' ..,lko,....,lxc'.. .cldxl. cKKXXNWXo,o0KN                            
                                    k'...:k0XWWWWNXO'   ...',;okkxd;......    .:lll;..c0KNNWWWNXx',O                            
                                    NKO:.;OXNWWWWWW0'  .....',lkkkkdollll:'..  ....,dkl':kXNWWWWx..k                            
                                      Nc ,OKXNNWWWW0, .......';ccccccccll;.......  .;lccc::xXNNWx..k                            
                                      NxclodOKXNN0kxl:;....';:::::::::;'.....,,,'.....;oc. 'odxkdcl0                            
                                         0:'lOOOOl'cKWx.   'oxxxxxxxxxl. ..'''''''''',''.....'''oNW                             
                                         WXKo'..,dKXW k. ...,;;;;;;;,,'.             .oKXXXXXXXXNW                              
                                           WKkkkOX Nxc;....,cllllll:,,.. .,;:ccc:.  ..;cdX                                      
                                                   K: .,;::clldkxdo;...,;codkkkOx; ..'. ,0                                      
                                                   K: 'ldxko:;ldl,'...'okkkkkkxdl,..',. ,0                                      
                                                 WWK:.;xkkkkxxc'.  ':clxkkkkkkc...,,,,..;0                                      
                                                WO::::okOkkkkx;.   'cllooc'''.''',,'..l0KW                                      
                                                Wd..;lc;;;;lxx;    ..''''......,,,,' .dW                                        
                                                Wd. ';'. ..'cc.         ......',,'',:cOW                                        
                                              WNXo.   ..',;'.    ...   .......',,. :K                                           
                                              Kc''....',;ldl,'.  ....... ......... :K                                           
                                           WOl:'....',:odxko;,.  .......... .. ....,cl0                                         
                                           Wo. ..'',:ldkkkko;,.  ................',' .dW                                        
                                         NK0l....',:dkkkkkko;,. .',''.......',,,,,,'..o0XW                                      
                                         O;......',:dkkkkkko;,. ;0Nd,.........',,,,,....:K                                      
                                         O' .....',:dkkkkkko;,. :K NK0k;.......'',,,,'. ,0                                      
                                         O'  .......,;lxkkkl''cdON    NOdddo;.....'',,. ,0                                      
                                      WKOd'   ....'...,cloo;..k            Nxc:::,...';:oX                                      
                                      Nl......';:oxdc;'...,,.,O              W  Nd'..,xW                                        
                                      Nc  ..',:oxxkkxdl,'..c0XW                  NXXXXN                                         
                                      Nc  .':odxkkkkkkxdl. cN                                                                   
                                      Nc  .'lkkkkkkkkkxoc. cN                                                                   
                                      Nc  .'lkkkkkkkkkl,,,;dN                                                                   
                                      Nl...'cxxkkkkkxxc.,ONW                                                                    
                                      WX0d'.,clxkkkd;'lOKN                                                                      
                                         Xkd:..,;;;cod0W                                                                        
                                           No.     ,0                                                                                                                                                                                 
        """, """                                                                                                                                                         
                                                                                                                                                                              
                                                                                                                                                                                                                                                                                            
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                                
                                                                                                                                                                                 
                                                                                                                                                                                
                                                                                                                                                                                
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                        
                                                                                                                                                                                
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                                                                                                                              
                                                                        XkxxxxxkK                                               
                                                                  NKKKKKx;.....,dKKKKN                                          
                                                                WWk,....;oxdddxxc'..'dNW                                        
                                                               Xd;,.....'::;';dkxooool:lK                                       
                                                             0dl,.....'';ll;.',;ldxkko,;loOW                                    
                                                            Wd. ...''',,:ll:,'..';:dkxdl. cN                                    
                                                          WNXo. ..',,,,',,,,,,,,. .lxxxo'.cKNW                                  
                                                          Kc''....',,'..,odddl;'..',;;;;'',';O                                  
                                                          0, .........;cokkkkxol;''',cxx:,. .k                                  
                                                          0,  ..  .;;;::lkkoc::::::,'cxd:'. .k                                  
                                                        NKx'     .;dko' .od,...':ol:,,'',,. .k                                  
                                                   WWWWNd'..    .'...   .',,,c0Xl..cxc',lxc.'k                                  
                                                  Nx:;;;,',cl'  .,.     .',lxOXNl  .';oo;'lOKN                                  
                                             Nkoooo:,,;;'.':lc:,...   .''';d0KXXc .,c:;:od0W                                    
                                        N0OOOx:..',coxkkc,'.'cko.    .';,,;d0KKKo,;okdcoK                                       
                                      WNO;...'clodxkkkkkkkl. ;xl. ..... ..,o00OO00OlckXNW                                       
                                     Wx,'..;odxxl;:okkkkkkl. .;,. .,,,... .lKx,.l00OOo;c0                                       
                                     Wo. ..;clxkdolc:lkkl,.  .'.  'loool;..;lloollc:;okON   WOlcccccdX                          
                                     Wo. ..'';collc'..;:'..   ....,looxkdc:,';lo;..';lxkX Xkxdl,. .:oxxKW                       
                                     Wx;,'....',;:;,''''...  .....',,;ldxkxc'.....'co;..dKd..dNk. lWKl,d0XN                     
                                      WNO, ...''oXNXXXXK:    ,do;''..',;cdxc,...;xo'.  .... .lXx. lNWNXd.;0                     
                                        0,   .lk0WWWWNXK:  ..';:lo:'...'';;...,:okd,.,llll:..oKd. cKNWWd.'O                     
                                        Nkd;..dKXWWWWWNK:  ....';ccllccc;......';c:,';llll:''dKOdlc:l0No.'O                     
                                          Wd..dKXWWWWWNX:  ......';loooo;  ...   ..','',,,'.':okXNd,;ldl:oK                     
                                          Wk',dOKNWWWX0k;..cl,...',,,,,,.   ....   ........... .dOOOd;'dN                       
                                           NXOc'l0XXXx'.,:ldxxdc..,odddd:..;dddo,         .''. .....:kXN                        
                                             W0kd:;;;,,;lxxkkkko. ,xkxc,;cldkkkkdlccc'    ;kOOkkkkkk0N                          
                                                Koc' .',;:lxOkko. .:::,':xOkkkkkkkkkkc. ..:dkX                                  
                                                NKO:.    ..coool:,,,,;::coodxkkkkxxdo;..,:'..k                                  
                                              WWk,......','....,ONNNWKl....:loxkdl:...,;ox:..k                                  
                                             Xd;,.....',cdool' ,0    WX000Ol........':odxkc..k                                  
                                           0dl,....'';lodkkkx; ,0       Xxo;.......:ldkxol, .k                                  
                                        N0Ol.....'';coxkkkxdo, ,0       O' ......';okkkx:',:l0                                  
                                        0;......';:okkkkkkd:,'.cK     NNk' .....,;cdkxxo' cX                                    
                                        0, .....:dxxkkkkkkl..oKXW    Nd,'.......:dxxko:,. cN                                    
                                   Koccc;.    ..'cldkkkxol;..dW      Nc  .......;cccc;..  .:oK                                  
                                W0xl'.............'lkkkx:.,co0       Nc  .......'''.....','.'lxON                               
                              NKO:........',::::,..:oodo, :X         Nc    ......... .;cdkdc:'.:kKN                             
                            WWk,........',;lxxxxxxo,..,,..cX         Nc  ...       ..:dxkkkxxc;,.'xWW                           
                           Xd;,.........,ldxkkkkkkx:'...o0KW         Nc  ..........',cxkkkkkkxdl,',;oK                          
                           K:  ..........,;;;;;;;;,... .k            Nc  ............',;;;;;;;;,... ,0                          
                           K:...........................k            Nl.............................;0                          
        """ };

            for (int i = 0; i < duration; i++)
            {
                foreach (string frame in frames)
                {
                    Console.Write(frame);
                    Thread.Sleep(100);
                    Console.SetCursorPosition(0, AnimationStartingLine);
                }
            }
        }

        Animation(1000);
    }

}