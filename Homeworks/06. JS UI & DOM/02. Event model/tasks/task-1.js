/* globals $ */

/*
 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
  * Change the content of all .button elements with "hide"
 When a .button is clicked:
  * Find the topmost .content element, that is before another .button and:
      - If the .content is visible:
          ~ Hide the .content
          ~ Change the content of the .button to "show"
      - If the .content is hidden:
          ~ Show the .content
          ~ Change the content of the .button to "hide"
      - If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
  * The provided DOM element is non-existant
  * The id is neither a string nor a DOM element
*/
//

function solve(){
  return function (selector) {
    if(!selector) {
      throw Error();
    }

    if(typeof selector !== 'string' && !(selector instanceof HTMLElement)) {
      throw Error();
    }

    let domElement;

    if(typeof selector === 'string') {
      domElement = document.getElementById(selector);

      if(!domElement) {
        throw Error();
      }
    } else {
      domElement = selector;
    }

    let allButtonsAndContentClassEelements = domElement.querySelectorAll('.button, .content');

    [].forEach.call(allButtonsAndContentClassEelements, el => {
      if(el.className === 'button') {
        el.innerHTML = 'hide';
      }
    });

    allButtonsAndContentClassEelements.addEventListener('click', ev => {
      let targetButton  = ev.target,
          nextEl = targetButton.nextElementSibling;

      if(nextEl.className === 'content') {
        let content = nextEl;

        while(nextEl) {
          if(nextEl === 'button') {
            if(content.style.visibility === 'none') {
              content.style.visibility = 'hidden';
              targetButton.innerHTML = 'show';
            } else {
              content.style.visibility = 'none';
              targetButton.innerHTML = 'hide';
            }

            break;
          }
          nextEl = nextEl.nextElementSibling;
        }
      }
    }, false)
  };
}

module.exports = solve;