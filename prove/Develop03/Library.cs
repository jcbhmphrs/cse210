using System;
public class Library
{
    private Random random = new Random();
    private List<string> _entries = new List<string>()
    {
    "1 Nephi 2:15|And my father dwelt in a tent.",
    "Jacob 6:12|O be wise; what can I say more?",
    "Enos 1:7|And I said: Lord, how is it done?",
    "Mosiah 21:4|Yea, all this was done that the word of the Lord might be fulfilled.",
    "3 Nephi 7:24|Now I would have you to remember also, that there were none who were brought unto repentance who were not baptized with water.",
    "Alma 6:4|And thus they began to establish the order of the church in the city of Zarahemla.",
    "Jacob 5:50|But, behold, the servant said unto the Lord of the vineyard: Spare it a little longer.",
    "Matthew 4:6-7|And saith unto him, If thou be the Son of God, cast thyself down: for it is written, He shall give his angels charge concerning thee: and in their hands they shall bear thee up, lest at any time thou dash thy foot against a stone. \nJesus said unto him, It is written again, Thou shalt not atempt the Lord thy God."    
    };
    public int GetEntryCount()
    {
        return _entries.Count();
    }
    public List<string> GetLibrary()
    {
        return _entries;
    }
    public string GetEntry(int position)
    {
        return _entries[position - 1];
    }
    public string GetRandomEntry()
    {
        return _entries[random.Next(_entries.Count())];
    }
}