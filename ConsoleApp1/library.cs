// Library for game to use containing words.
using System;
using System.Collections.Generic;

class WordLibrary
{
    public List<string> Fiveletter { get; private set; }

    public WordLibrary()
    {
        Fiveletter = new List<string> {
        "Abyss", "Ample", "Ankle", "Aroma", "Aural", "Began", "Blunt", "Braid", "Brisk", "Bumpy",
        "Chive", "Clasp", "Crave", "Crest", "Cumin", "Drape", "Dregs", "Dumpy", "Dusky", "Dwell",
        "Elite", "Ember", "Enact", "Evade", "Evoke", "Fable", "Flair", "Fluke", "Folly", "Gauze",
        "Giddy", "Gloom", "Gorge", "Gusty", "Haste", "Hilly", "Hippy", "Hovel", "Hunch", "Icily",
        "Inept", "Inert", "Irate", "Ivory", "Jaded", "Jazzy", "Jolly", "Joust", "Jumpy", "Kinky",
        "Knack", "Knave", "Knead", "Kudos", "Lanky", "Latch", "Lolly", "Lurid", "Mirth", "Moody",
        "Mourn", "Mower", "Muggy", "Nanny", "Nappy", "Nerve", "Nifty", "Nudge", "Olive", "Onset",
        "Oomph", "Ounce", "Ovals", "Peppy", "Pious", "Pique", "Plush", "Poise", "Quail", "Quake",
        "Quell", "Quill", "Quirk", "Ravel", "Reedy", "Ruddy", "Runic", "Sable", "Spicy", "Stilt",
        "Swath", "Swirl", "Toast", "Tonic", "Triad", "Tryst", "Tweak", "Apple", "Beach", "Brain",
        "Bread", "Brush", "Chair", "Chest", "Chord", "Click", "Clock", "Black", "Blind",
        "Cloud", "Dance", "Diary", "Drink", "Earth", "Flute", "Fruit", "Ghost", "Grape", "Green",
        "Happy", "Heart", "House", "Juice", "Light", "Money", "Music", "Party", "Pizza", "Plant",
        "Radio", "River", "Salad", "Sheep", "Shoes", "Smile", "Snack", "Snake", "Spice", "Spoon",
        "Storm", "Table", "Toast", "Tiger", "Train", "Water", "Whale", "Wheel", "Woman", "World",
        "Write", "Youth", "Above", "Acute", "Alive", "Alone", "Angry", "Aware", "Awful", "Basic",
        "Brave", "Brief", "Broad", "Brown", "Cheap", "Chief", "Civil", "Clean", "Clear", "Close",
        "Crazy", "Daily", "Dirty", "Early", "Empty", "Equal", "Exact", "Extra", "Faint", "False",
        "Fifth", "Final", "First", "Fresh", "Front", "Funny", "Giant", "Grand", "Great", "Green",
        "Gross", "Happy", "Harsh", "Heavy", "Human", "Ideal", "Inner", "Joint", "Large", "Legal",
        "Level", "Light", "Local", "Loose", "Lucky", "Magic", "Major", "Minor", "Moral", "Naked",
        "Nasty", "Naval", "Other", "Outer", "Plain", "Prime", "Prior", "Proud", "Quick", "Quiet",
        "Rapid", "Ready", "Right", "Roman", "Rough", "Round", "Royal", "Rural", "Sharp", "Sheer",
        "Short", "Silly", "Sixth", "Small", "Smart", "Solid", "Sorry", "Spare", "Steep", "Still",
        "Super", "Sweet", "Thick", "Third", "Tight", "Total", "Tough", "Upper", "Upset", "Urban",
        "Usual", "Vague", "Valid", "Vital", "White", "Whole", "Wrong", "Young", "Abuse", "Adult",
        "Agent", "Anger", "Apple", "Award", "Basis", "Beach", "Birth", "Block", "Blood", "Board",
        "Brain", "Bread", "Break", "Brown", "Buyer", "Cause", "Chain", "Chair", "Chest", "Chief",
        "Child", "China", "Claim", "Class", "Clock", "Coach", "Coast", "Court", "Cover", "Cream",
        "Crime", "Cross", "Crowd", "Crown", "Cycle", "Dance", "Death", "Depth", "Doubt", "Draft",
        "Drama", "Dream", "Dress", "Drink", "Drive", "Earth", "Enemy", "Entry", "Error", "Event",
        "Faith", "Fault", "Field", "Fight", "Final", "Floor", "Focus", "Force", "Frame", "Frank",
        "Front", "Fruit", "Glass", "Grant", "Grass", "Green", "Group", "Guide", "Heart", "Henry",
        "Horse", "Hotel", "House", "Image", "Index", "Input", "Issue", "Japan", "Jones", "Judge",
        "Knife", "Laura", "Layer", "Level", "Lewis", "Light", "Limit", "Lunch", "Major", "March",
        "Match", "Metal", "Model", "Money", "Month", "Motor", "Mouth", "Music", "Night", "Noise",
        "North", "Novel", "Nurse", "Offer", "Order", "Other", "Owner", "Panel", "Paper", "Party",
        "Peace", "Peter", "Phase", "Phone", "Piece", "Pilot", "Pitch", "Place", "Plane", "Plant",
        "Plate", "Point", "Pound", "Power", "Press", "Price", "Pride", "Prize", "Proof", "Queen",
        "Radio", "Range", "Ratio", "Reply", "Right", "River", "Round", "Route", "Rugby", "Scale",
        "Scene", "Scope", "Score", "Sense", "Shape", "Share", "Sheep", "Sheet", "Shift", "Shirt",
        "Shock", "Sight", "Simon", "Skill", "Sleep", "Smile", "Smith", "Smoke", "Sound", "South",
        "Space", "Speed", "Spite", "Sport", "Squad", "Staff", "Stage", "Start", "State", "Steam",
        "Steel", "Stock", "Stone", "Store", "Study", "Stuff", "Style", "Sugar", "Table", "Taste",
        "Terry", "Theme", "Thing", "Title", "Total", "Touch",
        "Train", "Treat", "Trust", "Visit", "Voice", "Waste", "Watch", "Worry", "Would", "Write"};
        // insert words between {}
    }

    public string GetRandomFiveletter()
    {
        return GetRandomWord(Fiveletter);
    }

    // if you want to add a 6 letter list, repeat above with new string and list
    private string GetRandomWord(List<string> wordList)
    {
        Random random = new Random();
        int index = random.Next(wordList.Count);
        return wordList[index];
    }
}
