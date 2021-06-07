using static NullObjextPattern.Program;

namespace NullObjextPattern
{
    public class MobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = NullMobile.GetInstance;
            switch (mobileName)
            {
                case "sony":
                    mobile = new SonyXperia();
                    break;

                case "apple":
                    mobile = new AppleIPhone();
                    break;

                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;
            }
            return mobile;
        }
    }
}