.load1 .loader,
.load1 .loader:before,
.load1 .loader:after {
  background: #FFF;
  -webkit-animation: load1 1s infinite ease-in-out;
  animation: load1 1s infinite ease-in-out;
  width: 1em;
  height: 4em;
}
.load1 .loader:before,
.load1 .loader:after {
  position: absolute;
  top: 0;
  content: '';
}
.load1 .loader:before {
  left: -1.5em;
  -webkit-animation-delay: -0.32s;
  animation-delay: -0.32s;
}
.load1 .loader {
  text-indent: -9999em;
  margin: 8em auto;
  position: relative;
  font-size: 11px;
  -webkit-animation-delay: -0.16s;
  animation-delay: -0.16s;
}
.load1 .loader:after {
  left: 1.5em;
}
@-webkit-keyframes load1 {
  0%,
  80%,
  100% {
    box-shadow: 0 0 #FFF;
    height: 4em;
  }
  40% {
    box-shadow: 0 -2em #ffffff;
    height: 5em;
  }
}
@keyframes load1 {
  0%,
  80%,
  100% {
    box-shadow: 0 0 #FFF;
    height: 4em;
  }
  40% {
    box-shadow: 0 -2em #ffffff;
    height: 5em;
  }
}
