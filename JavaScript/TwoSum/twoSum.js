// const numbers = [2, 7, 11, 15];
// const target = 9;

// const twoSum = (numbers, target) => {
//     for (let i = 0; i < numbers.length; i++) {
//         for (let j = i + 1; j < numbers.length; i++) {
//             if (numbers[i] + numbers[j] === target) {
//                 return [i, j];
//             }
//         }
//     }
//     return [];
// }

const twoSum = (numbers, target) => {
    const map = new Map();
    for (let i = 0; i < numbers.length; i++) {
        const complement = target - numbers[i];
        if (map.has(complement)) {
            console.log("has",map.has(complement));
            console.log("map:", map);
            return [map.get(complement), i];
        }
        map.set(numbers[i], i);
        console.log("map set:", map);
    }
    return [];
};

// console.log(twoSum(numbers, target));

module.exports = twoSum;