FROM ubuntu:16.04

SHELL [ "/bin/bash", "-c" ]

RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app
COPY . .

RUN apt-get update && apt-get install -y curl zip unzip
RUN curl -s get.sdkman.io | bash
RUN source /root/.sdkman/bin/sdkman-init.sh \
  && sdk install java \
  && sdk install kotlin \
  && sdk flush archives

RUN echo "alias gradle=/usr/src/app/gradlew" >> /root/.bash_aliases

CMD [ "/bin/bash" ]
