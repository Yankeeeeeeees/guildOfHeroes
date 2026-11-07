public class Computer {
    public string Brand;
    public string Whatis;
    public string Case;
    public string GPU;
    public string CPU;
    public int RAM;
    public string BP;
    public int Cost;
    

    public Computer(string whata, string corp, string gpu, string cpu, int ram, string bp, int cost) {
        Brand = "yankees dev";
        Whatis = whata;
        Case = corp;
        GPU = gpu;
        CPU = cpu;
        RAM = ram;
        BP = bp;
        Cost = cost;


    }
    public void ModernizationRam(int newRam) {
        if (newRam <= 0) {
            return;
        }
        RAM = newRam;
    }

    public void ModernizationBP(int newBP) {
        if (newBP <= 450) {
            return;
        }
        RAM = newBP;
    }
    public void UpdateCost(int newCost) {
        
    }
    public string GetInfoComp() {
        return $">>> {Brand} <<<\n" +
               $"Корпус: {Case}\n" +
               $"Графический процессор: {GPU}\n" +
               $"Процессор: {CPU}\n" +
               $"Оперативная память: {RAM}\n" +
               $"Блок питания (ВТ): {BP}\n"+
               $"Цена: {Cost}";
    }
    
    



}