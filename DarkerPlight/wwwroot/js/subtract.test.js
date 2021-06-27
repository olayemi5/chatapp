const functions = require('./subtract')

test('subtract two numbers',()=>{
    expect(
        functions.subtract(4,2)
    ).toBe(2)
})