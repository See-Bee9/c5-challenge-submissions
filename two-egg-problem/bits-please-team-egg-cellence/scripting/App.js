var [n, a, F, B] = process.argv;
var w = console.log;

J = (f) => {
    let j = f, w, p;
    let m = (n, s) => Math.floor(n/s) + s - 1;

    w = m(f, j);
    for (var i = 1; i < f; i++) {
        p = m(f, i);

        if (p < w) {
            j = i;
            w = p;
        }
        else if (p > w) break;
    }

    return j;
};

let c = 0, j, e = 0, d, y = 0;

while (c <= F) {
    j = e > 0 ? 1 : J(F - c);
    c = c + j <= F ? c + j : F;
    if (y != 0 && c == y) break;

    d = c >= B;
    w(`${c}\n${d}`);
    
    if (d) {
        e++;
        if (e == 2) break;
        y = c;
        c = c - j;
    }
}

w(`Floor ${c}`);