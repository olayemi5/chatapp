const functions = require('./clone')

test('clone an array sucessfully', () => {
    const array = [1,2,3,4,5]
    expect(
        functions.clone(array)
    ).toStrictEqual(array)
})