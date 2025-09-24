package org.mases.jnet;

import java.util.concurrent.*;

public class TestFuture {
    ExecutorService _service;

    public TestFuture() {
        _service = Executors.newCachedThreadPool();
    }

    public CompletableFuture<String> withComplete() throws InterruptedException {
        CompletableFuture<String> completableFuture = new CompletableFuture<>();

       _service.submit(() -> {
            Thread.sleep(500);
            completableFuture.complete("Hello");
            return null;
        });

        return completableFuture;
    }

    public CompletableFuture<String> withException() throws InterruptedException {
        CompletableFuture<String> completableFuture = new CompletableFuture<>();

       _service.submit(() -> {
            Thread.sleep(500);
            completableFuture.completeExceptionally(new UnsupportedOperationException("_service.submit", new UnsupportedOperationException("_service.submit", new UnsupportedOperationException("_service.submit"))));
            return null;
        });

        return completableFuture;
    }


}
