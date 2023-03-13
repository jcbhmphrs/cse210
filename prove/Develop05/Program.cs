using System;

class Program
{

    static void Main(string[] args)
    {
        void StartUpAnimation()
        {
            Console.CursorVisible = false;
            double loadingPercent = 0;
            Random random = new Random();
            int percentageJump;
            string loadingProgress = new string('|', Convert.ToInt32(loadingPercent / 1.428)); ;
            int AnimationStartingLine = Console.CursorTop;
            while (loadingPercent < 100)
            {
                string[] frames = { $"""                                                                              
                                              _                                                                       
                                             | |                                          _                         
            o  o          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_         o  o        
                 o       / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)             o      
                        ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_                     
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                   
                        (_____|                                 |_|                                              
                                                                                                                      
                                                  loading.                                                                            
                        {loadingProgress} {loadingPercent}% 

        """, $"""                                                                                                    
                                              _                                                                      
                                             | |                                          _                          
               o          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_            o         
                 o       / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)             o       
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o       
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                     
                        (_____|                                 |_|                                                
                                                                                                                      
                                                  loading.                                                                             
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                  
                                              _                                                                    
                                             | |                                          _                        
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                      
                 o       / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)             o       
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o       
               o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)           o         
                        (_____|                                 |_|                                               
                                                                                                                      
                                                  loading..                                                                             
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                 
                                              _                                                                   
                                             | |                                          _                       
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                   
                         / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)                      
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o        
            o  o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o  o          
                        (_____|                                 |_|                                                 
                                                                                                                      
                                                  loading..                                                                               
                        {loadingProgress} {loadingPercent}%  

        """, $"""                                                                                                   
                                              _                                                                     
                                             | |                                          _                         
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                       
                         / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)                       
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                
            o  o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o  o           
                        (_____|                                 |_|                                                  
                                                                                                                      
                                                  loading...                                                                                
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                    
                                              _                                                                        
                                             | |                                          _                            
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                          
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                  
            o            \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o                
                        (_____|                                 |_|                                                    
                                                                                                                      
                                                  loading...                                                                                  
                        {loadingProgress} {loadingPercent}%  

        """, $"""                                                                                                      
                                              _                                                                        
                                             | |                                          _                            
            o             ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_         o                
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                  
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                         
                        (_____|                                 |_|                                                    
                                                                                                                      
                                                  loading                                                                                  
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                      
                                              _                                                                        
                                             | |                                          _                            
            o  o          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_         o  o             
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
                        ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_                          
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                         
                        (_____|                                 |_|                                                    
                                                                                                                      
                                                  loading                                                                                  
                        {loadingProgress} {loadingPercent}%  

        """ };

                foreach (string frame in frames)
                {
                    Console.Write(frame.TrimEnd());
                    Thread.Sleep(75);
                    percentageJump = random.Next(1, 80);
                    if (percentageJump < 6)
                    {
                        loadingPercent += percentageJump;
                        loadingProgress = new string('|', Convert.ToInt32(loadingPercent / 1.428));
                        Console.Beep(600,200);
                    }
                    Console.SetCursorPosition(0, AnimationStartingLine);
                }

            }
            Console.CursorVisible = true;
        }
        StartUpAnimation();
    }

}