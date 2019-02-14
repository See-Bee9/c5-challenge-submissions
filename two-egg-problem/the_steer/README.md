Assumptions:

MaxFloor > 1 && MaxFloor <= 2^32
BreakFloor >= 1 && BreakFloor <= MaxFloor

If you have a one floor building - you know where that egg gets broken, you don't need my code for that.
If your building is > 2^32, I assume that other gravitational forces will be at play - who knows what star/planet that
egg is going to get broken on.

If I can prove that an egg will be broken on a given floor (e.g. I've tested all the other floors), then I skip testing
that floor (saving a step), and print the break floor.
