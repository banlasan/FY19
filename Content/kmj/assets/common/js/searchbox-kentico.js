$(function() {
  var searchForm = $('.searchBox .form'),

    formChildEl = searchForm
      .children()
      .clone(),

    newForm = $("<form>",
      {
        action: "https://search2.konicaminolta.net/",
        class: "newForm",
      });

  $(newForm).append(formChildEl);

  $('body').append(newForm);

  $('.searchBox .form, .searchBoxSP')
    .find('input[type="image"]')
    .click(function (e) {
      e.preventDefault();
      $('form.newForm').submit();
    });

  $('.searchBox .form, .searchBoxSP')
    .find('input#search')
    .change(function (e) {
      $('form.newForm #search').val($(this).val());
    });
});