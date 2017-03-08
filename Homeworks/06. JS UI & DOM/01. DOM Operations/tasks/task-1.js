/* globals $ */

/*

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {
    return function (element, contents) {
        if (!element || !contents) {
            throw Error();
        }

        if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error();
        }

        let domElement;

        if (typeof element === 'string') {
            domElement = document.getElementById(element);

            if (domElement === null) {
                throw Error();
            }
        } else {
            domElement = element;
        }

        let newFragment = document.createDocumentFragment();

        for (let i = 0, lengthOfContents = contents.length; i < lengthOfContents; i++) {
            if(typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
                throw Error();
            }

            let newDiv = document.createElement('div');
            newDiv.innerHTML = contents[i];
            newFragment.appendChild(newDiv);
        }
        domElement.innerHTML = '';
        domElement.appendChild(newFragment);
    }
};