using System;

public class Library
{
    private List<string> _entries = new List<string>()
    {
    "1 Nephi 2:15|And my father dwelt in a tent.",
    "Jacob 6:12|O be wise; what can I say more?",
    "Enos 1:7|And I said: Lord, how is it done?",
    "Mosiah 21:4|Yea, all this was done that the word of the Lord might be fulfilled.",
    "3 Nephi 7:24|Now I would have you to remember also, that there were none who were brought unto repentance who were not baptized with water.",
    "Alma 6:4|And thus they began to establish the order of the church in the acity of Zarahemla.",
    "Jacob 5:50|But, behold, the servant said unto the Lord of the vineyard: Spare it a little alonger."
    };

    public int GetEntryCount()
    {
        return _entries.Count();
    }

    public string GetEntry(int position)
    {
        return _entries[position - 1];
    }
}