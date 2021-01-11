using System;
namespace c_sharp_core_ppt5_hw
{
    public interface IDeveloper
    {
        string Tool {get; set;}
        int Counter { get; set; }
        void Create();
        void Destroy();
    }
}
