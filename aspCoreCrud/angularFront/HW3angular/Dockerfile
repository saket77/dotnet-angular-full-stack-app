FROM node:10.16.1-alpine as builder
WORKDIR /app
COPY . .
RUN npm i --no-package-lock
RUN node_modules/.bin/ng build --prod

FROM nginx:1.15.8-alpine
COPY --from=builder /app/dist/HW2 /usr/share/nginx/html