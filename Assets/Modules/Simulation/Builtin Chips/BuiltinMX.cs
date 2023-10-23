namespace DLS.Simulation.ChipImplementation
{
	using static PinState;

	public class BuiltinMX : BuiltinSimChip
	{
		public BuiltinMX(SimPin[] inputPins, SimPin[] outputPins) : base(inputPins, outputPins) { }

        protected override void ProcessInputs()
        {
			//Converts Binary To Decimal From Both Inputs
            int input = inputPins[0].State.ToInt() << 1 | inputPins[1].State.ToInt();
        
			//Resets Pins
            for(int i = 0; i < outputPins.Length;i++){
				outputPins[i].ReceiveInput(i == input ? HIGH : LOW);
			}
        }
	}
}
