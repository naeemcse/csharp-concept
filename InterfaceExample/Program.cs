
using InterfaceExample;

void Demo(IProducts item)
{
    item.CalculatoeServiceCharge();
    item.CalculatoeServiceCharge();
}

Demo(new Camera());