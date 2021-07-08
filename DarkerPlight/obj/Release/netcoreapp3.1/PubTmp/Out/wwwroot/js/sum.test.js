const functions = require('./sum')

test('properly add two numbers', () => {
    expect(
        functions.sum(6, 6)
    ).toBe(12)
})