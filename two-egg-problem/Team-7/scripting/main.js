export default ([,, z, l]) => {
  const {ceil: c, sqrt: v} = Math;
  const y = c(v(z));
  const x = (s, i) => {
    for(let f = s; f <= l; f += i) {
      console.log(`${f}\n${f >= l}`)
      if(f >= l) return f;
    }
  }
  const b = x(1, y);
  const a = x(b, 1);
  console.log(`Floor ${a}`);
}

