main(int argc, char** argv) {
    i N=a(argv[1]), b=a(argv[2]), s=1, e=2, t, z=N;
    do {
        t = e < 2 ? s : s + (i)(ceil((N-s) / sqrt(N-s)));
        p("%u\n", t);
        if (t >= b) {
            p("True\n");
            if (--e == 0 || t == b) {
                s = t;
                break;
            }
            z=t-1;
            t=s-1;
        } else 
            p("False\n");
        s = t+1;
    } while (s < z); 
    p("Floor %u\n", s);
}