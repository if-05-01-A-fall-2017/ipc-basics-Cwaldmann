//global
bool interested[3] = false;
int looser[2];
int prozessInCrit = 0;

enter(int pid)
{
	interested[pid] = true;
	looser = otherprozesses;
	while(checkIfUrLooser && interested[prozessInCrit]);
	prozessInCrit = pid;
}

leave(int pid)
{
	interested[pid] = false;
}

