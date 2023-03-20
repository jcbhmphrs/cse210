public class Animation
{
    public void Run(int frameDuration, int probability, int addedPercent)
    {
        Console.Clear();
        Console.CursorVisible = false;
        double loadingPercent = 0;
        Random random = new Random();
        List<string> computerJargon = new List<string>(){
                "Downloading Assets",
                "Rearranging Lines of Code",
                "Establishing Secure Link to GitHub",
                "Clearing All Drives",
                "Compiling Rubric Data",
                "Connecting to Remote Network",
                "Re-Booting Processing System",
                "Installing IOS",
                "Creating Command Terminals",
                "Hacking into FBI Servers",
                "Downloading Secure Files",
                "Cooling Down Hardware"
            };
        int percentageJump;
        string computerJargonWord = computerJargon[random.Next(computerJargon.Count())];
        string loadingProgress = new string('/', Convert.ToInt32(loadingPercent / 1.428)); ;
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
                                                                                                                      
                                             {computerJargonWord}.                                                                            
                        {loadingProgress} {loadingPercent}% 

        """, $"""                                                                                                    
                                              _                                                                      
                                             | |                                          _                          
               o          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_            o         
                 o       / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)             o       
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o       
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                     
                        (_____|                                 |_|                                                
                                                                                                                      
                                             {computerJargonWord}.                                                                             
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                  
                                              _                                                                    
                                             | |                                          _                        
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                      
                 o       / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)             o       
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o       
               o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)           o         
                        (_____|                                 |_|                                               
                                                                                                                      
                                             {computerJargonWord}..                                                                             
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                 
                                              _                                                                   
                                             | |                                          _                       
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                   
                         / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)                      
                 o      ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_              o        
            o  o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o  o          
                        (_____|                                 |_|                                                 
                                                                                                                      
                                             {computerJargonWord}..                                                                               
                        {loadingProgress} {loadingPercent}%  

        """, $"""                                                                                                   
                                              _                                                                     
                                             | |                                          _                         
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                       
                         / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)                       
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                
            o  o         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o  o           
                        (_____|                                 |_|                                                  
                                                                                                                      
                                             {computerJargonWord}...                                                                                
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                    
                                              _                                                                        
                                             | |                                          _                            
                          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_                          
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                  
            o            \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)        o                
                        (_____|                                 |_|                                                    
                                                                                                                      
                                             {computerJargonWord}...                                                                                  
                        {loadingProgress} {loadingPercent}%  

        """, $"""                                                                                                      
                                              _                                                                        
                                             | |                                          _                            
            o             ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_         o                
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
          o             ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_       o                  
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                         
                        (_____|                                 |_|                                                    
                                                                                                                      
                                             {computerJargonWord}                                                                                  
                        {loadingProgress} {loadingPercent}%   

        """, $"""                                                                                                      
                                              _                                                                        
                                             | |                                          _                            
            o  o          ____   ___   _____ | |    _____     ____  _   _  _____   ___  _| |_         o  o             
          o              / _  | / _ \ (____ || |   (_____)   / _  || | | || ___ | /___)(_   _)      o                  
                        ( (_| || |_| |/ ___ || |            | |_| || |_| || ____||___ |  | |_                          
                         \___ | \___/ \_____| \_)            \__  ||____/ |_____)(___/    \__)                         
                        (_____|                                 |_|                                                    
                                                                                                                      
                                             {computerJargonWord}                                                                                  
                        {loadingProgress} {loadingPercent}%  

        """ };
            foreach (string frame in frames)
            {
                Console.Write(frame.TrimEnd());
                Thread.Sleep(frameDuration);
                percentageJump = random.Next(1, probability);
                if (percentageJump <= addedPercent)
                {
                    loadingPercent += percentageJump;
                    loadingProgress = new string('|', Convert.ToInt32(loadingPercent / 1.428));
                }
                Console.SetCursorPosition(0, AnimationStartingLine);
                computerJargonWord = computerJargon[random.Next(computerJargon.Count())];
            }
        }
        Console.CursorVisible = true;
        Console.Clear();
    }
}
