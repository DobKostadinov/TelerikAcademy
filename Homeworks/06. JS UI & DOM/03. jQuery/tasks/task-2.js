/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
        if (selector && (selector !== 'string' || (selector instanceof jQuery))) {

            let $domElement = $(selector);

            if($domElement.length === 0) {
                throw Error();
            }

            let $allElementsWithClassButtonOrContent = $domElement.find('.button, .content');
            let elementsLength = $allElementsWithClassButtonOrContent.length;

            for (let i = 0; i < elementsLength; i++) {
                let element = $($allElementsWithClassButtonOrContent[i]);

                if(element.hasClass('button')) {
                    element.html('hide');
                    
                    element.on('click', function () {
                        let $currentButton = $(this),
                            $contentElement = $currentButton.next();

                        while(!$contentElement.hasClass('content')) {
                            $contentElement = $contentElement.next();
                        }

                        let isContentElementVisible = $contentElement.css('display');

                        if (isContentElementVisible === '' || isContentElementVisible === 'block' || isContentElementVisible === 'inline-block' || isContentElementVisible === 'inline') {
                            $contentElement.css('display', 'none');
                            $currentButton.html('show');
                        } else {
                            $contentElement.css('display', '');
                            $currentButton.html('hide');
                        }
                    })
                }
            }
        } else {
            throw Error();
        }
    };
}

module.exports = solve;