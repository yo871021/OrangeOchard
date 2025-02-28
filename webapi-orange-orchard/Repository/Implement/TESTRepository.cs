using Repository.Interface;

namespace Repository.Implement
{
    public class TESTRepository : DBRepositoryBase, ITESTRepository
    {
        public void TEST()
        {
            //不要可以 SELECT(...)
        }
    }
}
