function solve(){
  return function(selector){
        let $newMainDiv = $('<div />').addClass('dropdown-list'),
            $selectElFromDom = $(selector).css('display', 'none'),
            $currentDivEl = $('<div />').addClass('current').text('Select a value'),
            $optionsContainerDivEl = $('<div />').addClass('options-container').css('position', 'absolute').css('display', 'none'),
            $optionsInSelect = $(selector + ' option'),
            lengthOfOptions = $optionsInSelect.length;

      for (let i = 0; i < lengthOfOptions; i++) {
          let $newDivOptionEl = $('<div />')
              .addClass('dropdown-item')
              .attr('data-value', $($optionsInSelect[i]).attr('value'))
              .attr('data-index', i)
              .text($($optionsInSelect[i]).text());

         $optionsContainerDivEl.append($newDivOptionEl);
      }

      $newMainDiv.append($selectElFromDom, $currentDivEl, $optionsContainerDivEl);

      $('body').append($newMainDiv);


      $currentDivEl.on('click',function(){
          let display = $optionsContainerDivEl.css('display');

          $(this).text('Select a value');

          if(display === 'none'){
              $optionsContainerDivEl.css('display', '');
          } else {
              $optionsContainerDivEl.css('display', 'none');
          }
      });

      $optionsContainerDivEl.on('click', '.dropdown-item', function(){
          $selectElFromDom.val($(this).attr('data-value'));

          let text = $(this).text();

          $optionsContainerDivEl.css('display', 'none');
          $currentDivEl.text(text);
      });
  };
}

module.exports = solve;