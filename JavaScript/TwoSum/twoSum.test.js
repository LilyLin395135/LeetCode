// twoSum.test.js
const twoSum = require('./twoSum');

describe('twoSum function', () => {
    test('should return indices of the two numbers that add up to the target', () => {
        const numbers = [2, 7, 11, 15];
        const target = 9;
        const result = twoSum(numbers, target);
        expect(result).toEqual([0, 1]);
    });

    test('should return an empty array if no solution exists', () => {
        const numbers = [1, 2, 3];
        const target = 7;
        const result = twoSum(numbers, target);
        expect(result).toEqual([]);
    });

    test('should work with negative numbers', () => {
        const numbers = [-3, 4, 3, 90];
        const target = 0;
        const result = twoSum(numbers, target);
        expect(result).toEqual([0, 2]);
    });

    test('should handle duplicate numbers correctly', () => {
        const numbers = [3, 3, 4, 5];
        const target = 6;
        const result = twoSum(numbers, target);
        expect(result).toEqual([0, 1]);
    });
});
