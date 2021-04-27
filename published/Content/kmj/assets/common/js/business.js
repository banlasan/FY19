// アンカーリンク設定
$(function() {

// SP追従メニューボタン設定
$('.inherentNavigationBtn').click(function(){
    $(this).parents().find('.inherentNavigation').toggleClass('is-open');
});
if($('#stickyNav')[0]){
//　スティッキーヘッダー設定
var targetElement = document.getElementById("stickyNav");
var navPos = targetElement.offsetTop;
document.addEventListener('scroll', function(){

if ($(window).scrollTop() > navPos){
    $('#stickyNav').addClass('m_fixed');
}else{
    $('#stickyNav').removeClass('m_fixed');
}
},{passive: true});
}

// position: stickyがブラウザで使えるかチェックするための関数
function detectSticky() {
  const div = document.createElement('div');
  div.style.position = 'sticky';
  return div.style.position.indexOf('sticky') !== -1;
}

// .stickyが指定されている要素に対してposition: stickyを適用させる関数
function callStickyState() {
  return new StickyState(document.querySelectorAll('.sticky'));
}

// もしブラウザでposition: stickyが使えなければ、callStickyState関数を呼び出す
if (!detectSticky()) {
  callStickyState();
}

// アンカーリンク設定
//*ページ内リンク
$('a[href*=#]').click(function(){
    if (!$(this).hasClass('touchHover')) {
        var href= $(this).attr("href");
        var target = $(href == "#" || href == "" ? 'body' : href);
        var position = target.offset().top - 44;
        $("html, body").animate({scrollTop:position}, 550, "swing");
        return false;
    }
});
//*ページ外リンク*/      
var url = $(location).attr('href');
if (url.indexOf("?id=") == -1) {
    // ほかの処理
}else{
    var url_sp = url.split("?id=");
    var hash     = '#' + url_sp[url_sp.length - 1];
    var target2	= $(hash);
    var position2	= target2.offset().top;
    $("html, body").animate({scrollTop:position2}, 550, "swing");
}
});