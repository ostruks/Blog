using AutoMapper;

namespace BlogBL.BLModels
{
    internal static class Mapping<TBL, KDAL> where TBL : class where KDAL : class
    {
        private static IMapper _blMapper = new MapperConfiguration(
            conf =>
            {
                conf.CreateMap<TBL, KDAL>();
                conf.CreateMap<KDAL, TBL>();
            }).CreateMapper();
        internal static KDAL FromBlToDal(TBL article)
        {
            return _blMapper.Map<TBL, KDAL>(article);
        }
        internal static TBL FromDalToBl(KDAL article)
        {
            return _blMapper.Map<KDAL, TBL>(article);
        }
    }
}
