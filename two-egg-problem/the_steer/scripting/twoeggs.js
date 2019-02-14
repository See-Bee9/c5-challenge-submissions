p = console.log
N = process.argv[2]
b = process.argv[3]
s = 1
e = 2
z = N
do {
    t = e < 2 ? s : s + Math.ceil((N - s) / Math.sqrt(N - s))
    p(t)
    if (t >= b) {
        p("True");
        if (--e === 0 || t == b) {
            s = t
            break
        }
        z = t - 1
        t = s - 1
    } else p("False")
    s = t + 1
} while (s < z)
p("Floor", s)